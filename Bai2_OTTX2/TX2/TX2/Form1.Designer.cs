namespace TX2
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
            this.inpPhong = new System.Windows.Forms.TextBox();
            this.inpMa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.listLop = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonghoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.inpTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng học";
            // 
            // inpPhong
            // 
            this.inpPhong.Location = new System.Drawing.Point(280, 70);
            this.inpPhong.Name = "inpPhong";
            this.inpPhong.Size = new System.Drawing.Size(239, 22);
            this.inpPhong.TabIndex = 2;
            this.inpPhong.TextChanged += new System.EventHandler(this.inpPhong_TextChanged);
            // 
            // inpMa
            // 
            this.inpMa.Location = new System.Drawing.Point(280, 29);
            this.inpMa.Name = "inpMa";
            this.inpMa.Size = new System.Drawing.Size(239, 22);
            this.inpMa.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(602, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(604, 69);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(604, 114);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // listLop
            // 
            this.listLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.phonghoc});
            this.listLop.Location = new System.Drawing.Point(200, 190);
            this.listLop.Name = "listLop";
            this.listLop.RowHeadersWidth = 51;
            this.listLop.RowTemplate.Height = 24;
            this.listLop.Size = new System.Drawing.Size(452, 150);
            this.listLop.TabIndex = 7;
            this.listLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listLop_CellContentClick);
            // 
            // malop
            // 
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 200;
            // 
            // phonghoc
            // 
            this.phonghoc.HeaderText = "Phòng học";
            this.phonghoc.MinimumWidth = 6;
            this.phonghoc.Name = "phonghoc";
            this.phonghoc.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phòng học cần tìm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inpTim
            // 
            this.inpTim.Location = new System.Drawing.Point(280, 115);
            this.inpTim.Name = "inpTim";
            this.inpTim.Size = new System.Drawing.Size(239, 22);
            this.inpTim.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inpTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listLop);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.inpMa);
            this.Controls.Add(this.inpPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inpPhong;
        private System.Windows.Forms.TextBox inpMa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView listLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonghoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpTim;
    }
}

