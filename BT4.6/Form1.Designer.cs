namespace BT4._6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cboGender = new ComboBox();
            numAge = new NumericUpDown();
            txtFullName = new TextBox();
            txtStudentId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSelectAvatar = new Button();
            picAvatar = new PictureBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnExportCSV = new Button();
            dgvStudents = new DataGridView();
            bindingSource1 = new BindingSource(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboGender);
            groupBox1.Controls.Add(numAge);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtStudentId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Sinh viên";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(141, 151);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 23);
            cboGender.TabIndex = 7;
            // 
            // numAge
            // 
            numAge.Location = new Point(141, 103);
            numAge.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(157, 23);
            numAge.TabIndex = 6;
            numAge.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(141, 58);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(157, 23);
            txtFullName.TabIndex = 5;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(141, 17);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(157, 23);
            txtStudentId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 159);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 111);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Tuổi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh viên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSelectAvatar);
            groupBox2.Controls.Add(picAvatar);
            groupBox2.Location = new Point(388, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 193);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ảnh đại diện";
            // 
            // btnSelectAvatar
            // 
            btnSelectAvatar.Location = new Point(88, 142);
            btnSelectAvatar.Name = "btnSelectAvatar";
            btnSelectAvatar.Size = new Size(69, 39);
            btnSelectAvatar.TabIndex = 1;
            btnSelectAvatar.Text = "Chọn ảnh";
            btnSelectAvatar.UseVisualStyleBackColor = true;
            btnSelectAvatar.Click += btnSelectAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(75, 25);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(103, 101);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            picAvatar.Click += pictureBox1_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(55, 252);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(208, 252);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(355, 252);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(514, 252);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(75, 23);
            btnExportCSV.TabIndex = 5;
            btnExportCSV.Text = "Xuất file CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(37, 304);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(552, 75);
            dgvStudents.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "File ảnh (*.jpg;*.png)|*.jpg;*.png|Tất cả file (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "File CSV (*.csv)|*.csv|Tất cả file (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(btnExportCSV);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cboGender;
        private NumericUpDown numAge;
        private TextBox txtFullName;
        private TextBox txtStudentId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox picAvatar;
        private Button btnSelectAvatar;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnExportCSV;
        private DataGridView dgvStudents;
        private BindingSource bindingSource1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
