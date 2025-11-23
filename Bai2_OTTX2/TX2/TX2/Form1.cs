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

namespace TX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string tentep = @"C:\Users\Admin\Desktop\TichHop\DOM\Bai2_OTTX2\TX2\TX2\truonghoc.xml";
        int d = 0;

        private void HienThi()
        {
            doc.Load(tentep);
            listLop.Rows.Clear();

            XmlNodeList DS = doc.SelectNodes("/truonghoc/lophoc");
            listLop.ColumnCount = 2;
            listLop.Rows.Add();
            int sd = 0;

            foreach(XmlNode lop in DS)
            {
                string malop = lop.SelectSingleNode("malop").InnerText.ToString();
                string phong = lop.SelectSingleNode("phonghoc").InnerText.ToString();
                listLop.Rows[sd].Cells[0].Value = malop;
                listLop.Rows[sd].Cells[1].Value = phong;

                listLop.Rows.Add();
                sd++;
            }
        }
        private void inpPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            string malop = inpMa.Text.Trim();

            XmlNodeList prevDs = doc.SelectNodes("/truonghoc/lophoc");
            bool exists = false;

            foreach (XmlNode lop in prevDs)
            {
                string ml = lop.SelectSingleNode("malop").InnerText.ToString();
                if (ml == malop)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                MessageBox.Show("Trùng mã lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlElement lopmoi = doc.CreateElement("lophoc");

                XmlElement malopmoi = doc.CreateElement("malop");
                malopmoi.InnerText = inpMa.Text.Trim();
                lopmoi.AppendChild(malopmoi);

                XmlElement phongmoi = doc.CreateElement("phonghoc");
                phongmoi.InnerText = inpPhong.Text.Trim();
                lopmoi.AppendChild(phongmoi);

                goc.AppendChild(lopmoi);
                doc.Save(tentep);
                HienThi();
            }
        }

        private void listLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            inpMa.Text = listLop.Rows[d].Cells[0].Value.ToString();
            inpPhong.Text = listLop.Rows[d].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string malop = inpMa.Text.Trim();
                XmlNode lopcanxoa = doc.SelectSingleNode($"/truonghoc/lophoc[malop='{malop}']");
                if (lopcanxoa != null)
                {
                    doc.DocumentElement.RemoveChild(lopcanxoa);
                    doc.Save(tentep);
                    HienThi();
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            listLop.Rows.Clear();

            listLop.ColumnCount = 2;

            string phongtim = inpTim.Text.Trim();

            bool timthay = false;

            if (phongtim == "")
            {
                MessageBox.Show("Vui lòng nhập phòng học cần tìm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XmlNodeList ds = doc.SelectNodes("/truonghoc/lophoc");

                int sd = 0;
                foreach (XmlNode lop in ds)
                {
                    string phong = lop.SelectSingleNode("phonghoc").InnerText.ToString();
                    if (phong == phongtim)
                    {
                        string malop = lop.SelectSingleNode("malop").InnerText.ToString();
                        listLop.Rows.Add();
                        listLop.Rows[sd].Cells[0].Value = malop;
                        listLop.Rows[sd].Cells[1].Value = phong;
                        sd++;
                        timthay = true;
                    }
                }
                if (!timthay)
                {
                    MessageBox.Show("Không tìm thấy lớp học trong phòng học đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
