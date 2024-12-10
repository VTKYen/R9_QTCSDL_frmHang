namespace WinFormsAppFrmHang
{
    partial class FormHang
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
            label1 = new Label();
            txtMaH = new TextBox();
            btnThem = new Button();
            label2 = new Label();
            label3 = new Label();
            txtTenH = new TextBox();
            txtDonGia = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtTimKiem = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng";
            label1.Click += label1_Click;
            // 
            // txtMaH
            // 
            txtMaH.Location = new Point(158, 26);
            txtMaH.Name = "txtMaH";
            txtMaH.Size = new Size(268, 27);
            txtMaH.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 190);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(73, 35);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn giá";
            // 
            // txtTenH
            // 
            txtTenH.Location = new Point(158, 69);
            txtTenH.Name = "txtTenH";
            txtTenH.Size = new Size(268, 27);
            txtTenH.TabIndex = 6;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(168, 120);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(268, 27);
            txtDonGia.TabIndex = 7;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(222, 190);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 35);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(132, 190);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(73, 35);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(339, 190);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(73, 35);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaH);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtTenH);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 245);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(9, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(771, 178);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(699, 108);
            dataGridView1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(177, 153);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(268, 27);
            txtTimKiem.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 167);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Tìm kiếm";
            // 
            // FormHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormHang";
            Text = "FormHang";
            Load += FormHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMaH;
        private Button btnThem;
        private Label label2;
        private Label label3;
        private TextBox txtTenH;
        private TextBox txtDonGia;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}
