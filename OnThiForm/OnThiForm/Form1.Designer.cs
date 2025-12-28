namespace OnThiForm
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
            this.inpGia = new System.Windows.Forms.TextBox();
            this.inpTen = new System.Windows.Forms.TextBox();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.selectDM = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.listSP = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inpMaDanhMuc = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sản phẩm";
            // 
            // inpGia
            // 
            this.inpGia.Location = new System.Drawing.Point(259, 107);
            this.inpGia.Name = "inpGia";
            this.inpGia.Size = new System.Drawing.Size(280, 22);
            this.inpGia.TabIndex = 4;
            // 
            // inpTen
            // 
            this.inpTen.Location = new System.Drawing.Point(259, 67);
            this.inpTen.Name = "inpTen";
            this.inpTen.Size = new System.Drawing.Size(280, 22);
            this.inpTen.TabIndex = 5;
            // 
            // inpMa
            // 
            this.inpMa.Location = new System.Drawing.Point(259, 30);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(280, 22);
            this.inpMa.TabIndex = 6;
            // 
            // selectDM
            // 
            this.selectDM.FormattingEnabled = true;
            this.selectDM.Location = new System.Drawing.Point(259, 145);
            this.selectDM.Name = "selectDM";
            this.selectDM.Size = new System.Drawing.Size(280, 24);
            this.selectDM.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(625, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(625, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(625, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listSP
            // 
            this.listSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.DonGia,
            this.MaDanhMuc});
            this.listSP.Location = new System.Drawing.Point(147, 234);
            this.listSP.Name = "listSP";
            this.listSP.RowHeadersWidth = 51;
            this.listSP.RowTemplate.Height = 24;
            this.listSP.Size = new System.Drawing.Size(553, 150);
            this.listSP.TabIndex = 11;
            this.listSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã SP";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên sản phẩm";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Mã danh mục";
            this.MaDanhMuc.MinimumWidth = 6;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.Width = 125;
            // 
            // inpMaDanhMuc
            // 
            this.inpMaDanhMuc.Location = new System.Drawing.Point(259, 403);
            this.inpMaDanhMuc.Name = "inpMaDanhMuc";
            this.inpMaDanhMuc.Size = new System.Drawing.Size(294, 22);
            this.inpMaDanhMuc.TabIndex = 12;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(559, 402);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.inpMaDanhMuc);
            this.Controls.Add(this.listSP);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.selectDM);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.inpTen);
            this.Controls.Add(this.inpGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpGia;
        private System.Windows.Forms.TextBox inpTen;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.ComboBox selectDM;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView listSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.TextBox inpMaDanhMuc;
        private System.Windows.Forms.Button btnTim;
    }
}

