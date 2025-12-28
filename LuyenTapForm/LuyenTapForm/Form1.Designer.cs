namespace LuyenTapForm
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.inpMaDV = new System.Windows.Forms.TextBox();
            this.inpHSLuong = new System.Windows.Forms.TextBox();
            this.inpGT = new System.Windows.Forms.TextBox();
            this.inpTen = new System.Windows.Forms.TextBox();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.listNV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inpEnd = new System.Windows.Forms.TextBox();
            this.inpStart = new System.Windows.Forms.TextBox();
            this.btnTimHS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma don vi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "He so luong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gioi tinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ho ten";
            // 
            // inpMaDV
            // 
            this.inpMaDV.Location = new System.Drawing.Point(279, 187);
            this.inpMaDV.Name = "inpMaDV";
            this.inpMaDV.Size = new System.Drawing.Size(261, 22);
            this.inpMaDV.TabIndex = 5;
            // 
            // inpHSLuong
            // 
            this.inpHSLuong.Location = new System.Drawing.Point(279, 148);
            this.inpHSLuong.Name = "inpHSLuong";
            this.inpHSLuong.Size = new System.Drawing.Size(261, 22);
            this.inpHSLuong.TabIndex = 6;
            // 
            // inpGT
            // 
            this.inpGT.Location = new System.Drawing.Point(279, 109);
            this.inpGT.Name = "inpGT";
            this.inpGT.Size = new System.Drawing.Size(261, 22);
            this.inpGT.TabIndex = 7;
            // 
            // inpTen
            // 
            this.inpTen.Location = new System.Drawing.Point(279, 72);
            this.inpTen.Name = "inpTen";
            this.inpTen.Size = new System.Drawing.Size(261, 22);
            this.inpTen.TabIndex = 8;
            // 
            // inpMa
            // 
            this.inpMa.Location = new System.Drawing.Point(279, 32);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(261, 22);
            this.inpMa.TabIndex = 9;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(649, 158);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tim Gioi tinh";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(649, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(649, 72);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(649, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listNV
            // 
            this.listNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.GioiTinh,
            this.HSLuong,
            this.MaDonVi});
            this.listNV.Location = new System.Drawing.Point(68, 227);
            this.listNV.Name = "listNV";
            this.listNV.RowHeadersWidth = 51;
            this.listNV.RowTemplate.Height = 24;
            this.listNV.Size = new System.Drawing.Size(675, 150);
            this.listNV.TabIndex = 15;
            this.listNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listNV_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ma nhan vien";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Ma nhan vien";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Ho ten";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Gioi tinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // HSLuong
            // 
            this.HSLuong.DataPropertyName = "HSLuong";
            this.HSLuong.HeaderText = "He so luong";
            this.HSLuong.MinimumWidth = 6;
            this.HSLuong.Name = "HSLuong";
            this.HSLuong.Width = 125;
            // 
            // MaDonVi
            // 
            this.MaDonVi.DataPropertyName = "MaDonVi";
            this.MaDonVi.HeaderText = "Don vi";
            this.MaDonVi.MinimumWidth = 6;
            this.MaDonVi.Name = "MaDonVi";
            this.MaDonVi.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ket thuc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bat dau";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // inpEnd
            // 
            this.inpEnd.Location = new System.Drawing.Point(469, 393);
            this.inpEnd.Name = "inpEnd";
            this.inpEnd.Size = new System.Drawing.Size(198, 22);
            this.inpEnd.TabIndex = 19;
            // 
            // inpStart
            // 
            this.inpStart.Location = new System.Drawing.Point(182, 393);
            this.inpStart.Name = "inpStart";
            this.inpStart.Size = new System.Drawing.Size(171, 22);
            this.inpStart.TabIndex = 20;
            // 
            // btnTimHS
            // 
            this.btnTimHS.Location = new System.Drawing.Point(682, 392);
            this.btnTimHS.Name = "btnTimHS";
            this.btnTimHS.Size = new System.Drawing.Size(75, 23);
            this.btnTimHS.TabIndex = 21;
            this.btnTimHS.Text = "Tim";
            this.btnTimHS.UseVisualStyleBackColor = true;
            this.btnTimHS.Click += new System.EventHandler(this.btnTimHS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimHS);
            this.Controls.Add(this.inpStart);
            this.Controls.Add(this.inpEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listNV);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.inpTen);
            this.Controls.Add(this.inpGT);
            this.Controls.Add(this.inpHSLuong);
            this.Controls.Add(this.inpMaDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpMaDV;
        private System.Windows.Forms.TextBox inpHSLuong;
        private System.Windows.Forms.TextBox inpGT;
        private System.Windows.Forms.TextBox inpTen;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView listNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonVi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inpEnd;
        private System.Windows.Forms.TextBox inpStart;
        private System.Windows.Forms.Button btnTimHS;
    }
}

