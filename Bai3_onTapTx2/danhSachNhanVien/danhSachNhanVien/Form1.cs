using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace danhSachNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string tentep = @"C:\Users\Admin\Desktop\TichHop\DOM\Bai3_onTapTx2\danhSachNhanVien\danhSachNhanVien\nhanvien.xml";
        int d;

        private void HienThi()
        {
            doc.Load(tentep);
            listNV.Rows.Clear();
            XmlNodeList ds = doc.SelectNodes("ds/nhanvien");

            listNV.ColumnCount = 4;
            listNV.Rows.Add();

            int sd = 0; 

            foreach (XmlNode nv in ds)
            {
                string manv = nv.SelectSingleNode("@manv").InnerText;

                XmlNode hoten = nv.SelectSingleNode("hoten");
                string ho = hoten.SelectSingleNode("ho").InnerText;
                string ten = hoten.SelectSingleNode("ten").InnerText;

                string diachi = nv.SelectSingleNode("diachi").InnerText;

                listNV.Rows[sd].Cells[0].Value = manv;
                listNV.Rows[sd].Cells[1].Value = ho;
                listNV.Rows[sd].Cells[2].Value = ten;
                listNV.Rows[sd].Cells[3].Value = diachi;

                sd++;
                listNV.Rows.Add();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            string manv = inpMaNV.Text.Trim();
            string ho = inpHo.Text.Trim();
            string ten = inpTen.Text.Trim();
            string diachi = inpDiaChi.Text.Trim();

            XmlNode nv_cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + manv + "']");

            if (nv_cu != null)
            {
                XmlNode nv_moi = doc.CreateElement("nhanvien");

                XmlAttribute ma = doc.CreateAttribute("manv");
                ma.InnerText = manv;
                nv_moi.Attributes.Append(ma);

                XmlElement hoten = doc.CreateElement("hoten");
                XmlElement h = doc.CreateElement("ho");
                h.InnerText = ho;
                hoten.AppendChild(h);
                XmlElement t = doc.CreateElement("ten");
                t.InnerText = ten;
                hoten.AppendChild(t);
                nv_moi.AppendChild(hoten);

                XmlElement dc = doc.CreateElement("diachi");
                dc.InnerText = diachi;
                nv_moi.AppendChild(dc);

                goc.ReplaceChild(nv_moi, nv_cu);
                doc.Save(tentep);
                HienThi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã đã nhập.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            string manv = inpMaNV.Text;
            string ho = inpHo.Text;
            string ten = inpTen.Text;
            string diachi = inpDiaChi.Text;

            XmlElement nhanvien = doc.CreateElement("nhanvien");

            XmlAttribute ma = doc.CreateAttribute("manv");
            ma.InnerText = manv;
            nhanvien.Attributes.Append(ma);

            XmlElement hoten = doc.CreateElement("hoten");
            XmlElement h = doc.CreateElement("ho");
            h.InnerText = ho;
            hoten.AppendChild(h);
            XmlElement t = doc.CreateElement("ten");
            t.InnerText = ten;
            hoten.AppendChild(t);
            nhanvien.AppendChild(hoten);

            XmlElement dc = doc.CreateElement("diachi");
            dc.InnerText = diachi;
            nhanvien.AppendChild(dc);

            goc.AppendChild(nhanvien);

            doc.Save(tentep);

            HienThi();
        }

        private void listNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            inpMaNV.Text = listNV.Rows[d].Cells[0].Value.ToString();
            inpHo.Text = listNV.Rows[d].Cells[1].Value.ToString();
            inpTen.Text = listNV.Rows[d].Cells[2].Value.ToString();
            inpDiaChi.Text = listNV.Rows[d].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            string manv = inpMaNV.Text.Trim();
            XmlNode nv_xoa = goc.SelectSingleNode("/ds/nhanvien[@manv='" + manv + "']");

            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }


            // Hỏi xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhân viên có mã: {manv}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
            {
                return; // Người dùng không muốn xóa
            }

            goc.RemoveChild(nv_xoa);

            doc.Save(tentep);

            MessageBox.Show("Xóa nhân viên thành công!");

            HienThi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            string manv = inpMaNV.Text.Trim();
            string ho = inpHo.Text.Trim();
            string ten = inpTen.Text.Trim();
            string diachi = inpDiaChi.Text.Trim();

            XmlNodeList ds = doc.SelectNodes("ds/nhanvien");

            if (manv == "" && ho == "" && ten == "" && diachi == "")
            {
                HienThi();
                return;
            }

            int c = 0;
            listNV.ColumnCount = 4;
            listNV.Rows.Clear();
            bool timthay = false;

            foreach (XmlNode nv in ds)
            {
                string ma = nv.SelectSingleNode("@manv").InnerText;
                XmlNode hoten = nv.SelectSingleNode("hoten");
                string h = hoten.SelectSingleNode("ho").InnerText;
                string t = hoten.SelectSingleNode("ten").InnerText;
                string dc = nv.SelectSingleNode("diachi").InnerText;

                if(ma == manv || h == ho || t == ten || dc == diachi)
                {
                    listNV.Rows.Add();
                    listNV.Rows[c].Cells[0].Value = ma;
                    listNV.Rows[c].Cells[1].Value = h;
                    listNV.Rows[c].Cells[2].Value = t;
                    listNV.Rows[c].Cells[3].Value = dc;

                    timthay = true;
                    c++;
                }
            }

            if(!timthay)
            {
                MessageBox.Show("Không tìm thấy nhân viên với thông tin đã nhập.");
                HienThi();
            }
        }
    }
}
