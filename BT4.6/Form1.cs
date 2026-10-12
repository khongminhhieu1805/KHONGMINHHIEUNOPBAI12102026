using System.ComponentModel;
using System.Text;

namespace BT4._6
{

    public partial class Form1 : Form
    {
        private BindingList<Student> studentList = new BindingList<Student>();
        private BindingSource bindingSource = new BindingSource();
        public class Student
        {
            public string StudentId { get; set; }
            public string FullName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string AvatarPath { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = studentList;
            dgvStudents.DataSource = bindingSource;

            // Thiết lập DataBindings 2 chiều cho các Control nhập liệu
            txtStudentId.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            numAge.DataBindings.Add("Value", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("Text", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            // Bắt sự kiện chuyển dòng trên Grid để nạp ảnh
            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
        }
        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent && File.Exists(currentStudent.AvatarPath))
            {
                // Dùng MemoryStream để không bị khóa file trên ổ cứng, cho phép xóa/ghi đè file ảnh
                using (var stream = new FileStream(currentStudent.AvatarPath, FileMode.Open, FileAccess.Read))
                {
                    picAvatar.Image = Image.FromStream(stream);
                }
            }
            else
            {
                picAvatar.Image = null; // Trống nếu không có đường dẫn hợp lệ
            }
        }
        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && bindingSource.Current is Student std)
            {
                std.AvatarPath = openFileDialog1.FileName;
                BindingSource_CurrentChanged(null, null); // Kích hoạt lại để hiển thị ảnh vừa chọn
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Tạo đối tượng mới và gán giá trị lấy từ các Control trên giao diện
            Student newStudent = new Student
            {
                StudentId = txtStudentId.Text,
                FullName = txtFullName.Text,
                Age = (int)numAge.Value,
                Gender = cboGender.Text,
                AvatarPath = picAvatar.Tag != null ? picAvatar.Tag.ToString() : ""
            };

            // 3. Thêm vào danh sách và cập nhật hiển thị
            studentList.Add(newStudent);
            bindingSource.ResetBindings(false);

            // 4. Di chuyển con trỏ tới dòng vừa thêm
            bindingSource.MoveLast();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bindingSource.ResetCurrentItem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student std)
            {
                DialogResult rs = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {std.FullName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    studentList.Remove(std);
                }
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "DanhSachSinhVien.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Encoding.UTF8 hỗ trợ tiếng Việt có dấu
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                    {
                        // Ghi dòng tiêu đề
                        sw.WriteLine("Mã SV,Họ Tên,Tuổi,Giới Tính,Đường dẫn ảnh");

                        // Ghi dữ liệu
                        foreach (var std in studentList)
                        {
                            sw.WriteLine($"\"{std.StudentId}\",\"{std.FullName}\",{std.Age},\"{std.Gender}\",\"{std.AvatarPath}\"");
                        }
                    }
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
