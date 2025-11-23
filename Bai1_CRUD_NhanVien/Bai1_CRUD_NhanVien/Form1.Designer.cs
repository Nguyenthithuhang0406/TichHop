namespace Bai1_CRUD_NhanVien
{
    partial class formNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inpMaNV = new System.Windows.Forms.TextBox();
            this.inpHoTen = new System.Windows.Forms.TextBox();
            this.inpDiaChi = new System.Windows.Forms.TextBox();
            this.listNV = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // inpMaNV
            // 
            this.inpMaNV.Location = new System.Drawing.Point(289, 29);
            this.inpMaNV.Name = "inpMaNV";
            this.inpMaNV.Size = new System.Drawing.Size(281, 22);
            this.inpMaNV.TabIndex = 3;
            // 
            // inpHoTen
            // 
            this.inpHoTen.Location = new System.Drawing.Point(289, 71);
            this.inpHoTen.Name = "inpHoTen";
            this.inpHoTen.Size = new System.Drawing.Size(281, 22);
            this.inpHoTen.TabIndex = 4;
            // 
            // inpDiaChi
            // 
            this.inpDiaChi.Location = new System.Drawing.Point(289, 115);
            this.inpDiaChi.Name = "inpDiaChi";
            this.inpDiaChi.Size = new System.Drawing.Size(281, 22);
            this.inpDiaChi.TabIndex = 5;
            // 
            // listNV
            // 
            this.listNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.diachi});
            this.listNV.Location = new System.Drawing.Point(12, 229);
            this.listNV.Name = "listNV";
            this.listNV.RowHeadersWidth = 51;
            this.listNV.RowTemplate.Height = 24;
            this.listNV.Size = new System.Drawing.Size(765, 150);
            this.listNV.TabIndex = 6;
            this.listNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listNV_CellContentClick);
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 300;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 300;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(631, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(631, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(631, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(631, 164);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // formNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listNV);
            this.Controls.Add(this.inpDiaChi);
            this.Controls.Add(this.inpHoTen);
            this.Controls.Add(this.inpMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNhap";
            this.Text = "Form nhập hồ sơ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpMaNV;
        private System.Windows.Forms.TextBox inpHoTen;
        private System.Windows.Forms.TextBox inpDiaChi;
        private System.Windows.Forms.DataGridView listNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}

