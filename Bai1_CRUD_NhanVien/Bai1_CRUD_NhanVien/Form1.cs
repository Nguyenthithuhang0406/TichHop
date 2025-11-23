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

namespace Bai1_CRUD_NhanVien
{
    public partial class formNhap : Form
    {
        public formNhap()
        {
            InitializeComponent();
        }


        // tạo đối tượng sử dụng tài liệu XML
        XmlDocument doc = new XmlDocument();
        //Đường dẫn tới file XML
        string tentep = @"C:\Users\Admin\Desktop\TichHop\DOM\Bai1_CRUD_NhanVien\Bai1_CRUD_NhanVien\dsnhanvien.xml";
        //Xác định chỉ số dòng được chọn trên DataGrid
        int d;

        private void HienThi()
        {
            listNV.Rows.Clear();
            doc.Load(tentep);
            //Tạo đối tượng DS chứa danh sách các nút nhân viên
            XmlNodeList DS = doc.SelectNodes("/ds/nhanvien");
            int sd = 0;
            listNV.ColumnCount = 3;
            listNV.Rows.Add();

            // Duyệt từng nút nhân viên
            foreach (XmlNode nhan_vien in DS)
            {
                //Truy xuất thuộc tính @manv
                XmlNode ma_nv = nhan_vien.SelectSingleNode("@manv");
                // Lấy giá trị của thuộc tính @manv đưa lên cột thứ 1 của dòng trên DataGrid
                listNV.Rows[sd].Cells[0].Value = ma_nv.InnerText.ToString();

                //Truy xuất nút hoten
                XmlNode ho_ten = nhan_vien.SelectSingleNode("hoten");
                //Lấy giá trị của nút hoten đưa lên cột thứ 2 của DataGrid
                listNV.Rows[sd].Cells[1].Value = ho_ten.InnerText.ToString();

                XmlNode dia_chi = nhan_vien.SelectSingleNode("diachi");
                listNV.Rows[sd].Cells[2].Value = dia_chi.InnerText.ToString();

                listNV.Rows.Add();
                sd++;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Đọc tài liệu Xml
            doc.Load(tentep);
            //Truy xuất nút gốc của tài liệu XML
            XmlElement goc = doc.DocumentElement;

            //tạo một nút nhân viên
            XmlNode nhan_vien = doc.CreateElement("nhanvien");
            //Tạo thuộc tính manv cho nút nhân viên
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            //Xác định giá trị cho thuộc tính manv
            ma_nv.Value = inpMaNV.Text;
            //Bổ sung manv vào nút nhân viên
            nhan_vien.Attributes.Append(ma_nv);

            //Tạo nút họ tên
            XmlNode ho_ten = doc.CreateElement("hoten");
            //Xác định giá trị của hoten
            ho_ten.InnerText = inpHoTen.Text;
            //Bổ sung nút họ tên vào nút nhân viên
            nhan_vien.AppendChild(ho_ten);

            //Tạo một nút địa chỉ
            XmlNode dia_chi = doc.CreateElement("diachi");
            //Xác định giá trị cho nút địa chỉ
            dia_chi.InnerText = inpDiaChi.Text;
            //Bổ sung nút địa chỉ vào nút nhân viên
            nhan_vien.AppendChild(dia_chi);

            goc.AppendChild(nhan_vien);

            //Lưu tài liệu XML
            doc.Save(tentep);
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            //Xác định nút cần xóa
            XmlNode nhan_vien_xoa = goc.SelectSingleNode("/ds/nhanvien[@manv='" + inpMaNV.Text + "']");
            goc.RemoveChild(nhan_vien_xoa);
            doc.Save(tentep);
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            //Xác định nút nhân viên cần sửa
            XmlNode nhan_vien_cu = goc.SelectSingleNode("/ds/nhanvien[@manv='" + inpMaNV.Text + "']");

            XmlNode nhan_vien_moi = doc.CreateElement("nhanvien");
            XmlAttribute ma_nv = doc.CreateAttribute("manv");
            ma_nv.InnerText = inpMaNV.Text;
            nhan_vien_moi.Attributes.Append(ma_nv);

            XmlNode ho_ten = doc.CreateElement("hoten");
            ho_ten.InnerText = inpHoTen.Text;
            nhan_vien_moi.AppendChild(ho_ten);

            XmlNode dia_chi = doc.CreateElement("diachi");
            dia_chi.InnerText = inpDiaChi.Text;
            nhan_vien_moi.AppendChild(dia_chi);

            //thay nút nhanvien cũ bằng nút nhanvien mới
            goc.ReplaceChild(nhan_vien_moi, nhan_vien_cu);
            doc.Save(tentep);
            HienThi();
        }

        private void listNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            inpMaNV.Text = listNV.Rows[d].Cells[0].Value.ToString();
            inpHoTen.Text = listNV.Rows[d].Cells[1].Value.ToString();
            inpDiaChi.Text = listNV.Rows[d].Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            string ma = inpMaNV.Text.Trim();
            string ten = inpHoTen.Text.Trim();
            string diachi = inpDiaChi.Text.Trim();

            //Nếu cả 3 ô đều rỗng => hiển thị lại danh sách
            if (ma == "" && ten == "" && diachi == "")
            {
                HienThi();
                return;
            }

            //Lấy danh sách nhân viên
            XmlNodeList ds = goc.SelectNodes("/ds/nhanvien");

            //Xóa danh sách cũ trên DataGrid
            listNV.Rows.Clear();
            listNV.ColumnCount = 3;

            int row = 0;
            bool timthay = false;

            //Lọc dữ liệu theo 3 tiêu chí
            foreach (XmlNode nv in ds)
            {
                string manv = nv.Attributes["manv"].InnerText;
                string hoten = nv.SelectSingleNode("hoten").InnerText;
                string dc = nv.SelectSingleNode("diachi").InnerText;

                //Điều kiện tìm: chỉ cần 1 trong 3 đúng
                if ((ma != "" && manv.Contains(ma)) || (ten != "" && hoten.Contains(ten)) || (diachi != "" && dc.Contains(diachi))){
                    //Thêm dòng vào DataGrid
                    listNV.Rows.Add();
                    listNV.Rows[row].Cells[0].Value = nv.Attributes["manv"].InnerText;
                    listNV.Rows[row].Cells[1].Value = nv.SelectSingleNode("hoten").InnerText;
                    listNV.Rows[row].Cells[2].Value = nv.SelectSingleNode("diachi").InnerText;

                    row++;
                    timthay = true;
                }
            }

            if (!timthay)
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp");
                listNV.Rows.Clear();
            }
        }
    }
}
