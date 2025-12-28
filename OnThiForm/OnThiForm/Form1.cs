using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace OnThiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadDataGridView()
        {
            string link = "http://localhost:90/hocrestful/api/sanpham";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));

            object data = js.ReadObject(response.GetResponseStream());
            // ép kiểu
            SanPham[] arr = data as SanPham[];
            listSP.DataSource = arr;
        }

        public void LoadComboBox()
        {
            string link = "http://localhost:90/hocrestful/api/danhmuc";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());

            DanhMuc[] arr1 = data as DanhMuc[];
            selectDM.DataSource = arr1;
            selectDM.ValueMember = "MaDanhMuc";
            selectDM.DisplayMember = "TenDanhMuc";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBox();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            inpMa.Text = listSP.Rows[d].Cells[0].Value.ToString();
            inpTen.Text = listSP.Rows[d].Cells[1].Value.ToString();
            inpGia.Text = listSP.Rows[d].Cells[2].Value.ToString();
            selectDM.Text = listSP.Rows[d].Cells[3].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string madm = inpMaDanhMuc.Text;
            string link = "http://localhost:90/hocrestful/api/sanpham?madm=" + madm;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));

            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arr = data as SanPham[];

            if (arr == null || arr.Length == 0)
            {
                listSP.DataSource = null;
                MessageBox.Show("Không tìm thấy sản phẩm");
                return;
            }

            listSP.DataSource = arr;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", inpMa.Text, inpTen.Text, inpGia.Text, selectDM.SelectedValue);
            
            string link = "http://localhost:90/hocrestful/api/sanpham"+ postString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";

            Stream dataStream = request.GetRequestStream();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));

            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", inpMa.Text, inpTen.Text, inpGia.Text, selectDM.SelectedValue);
            string link = "http://localhost:90/hocrestful/api/sanpham" + putString;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";

            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = inpMa.Text;
            string deleteString = string.Format("?ma={0}", masp);

            string link = "http://localhost:90/hocrestful/api/sanpham" + deleteString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "DELETE";

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;

            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
