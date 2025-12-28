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

namespace LuyenTapForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadDataGridView()
        {
            string link = "https://localhost:44314/api/nhanvien";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] arr = data as NhanVien[];
            listNV.DataSource = arr;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postSring = string.Format("?ma={0}&ten={1}&gioitinh={2}&hsluong={3}&madv={4}",
                inpMa.Text, inpTen.Text, inpGT.Text, inpHSLuong.Text, inpMaDV.Text);
            string link = "https://localhost:44314/api/nhanvien" + postSring;

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

        private void listNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            inpMa.Text = listNV.Rows[d].Cells[0].Value.ToString();
            inpTen.Text = listNV.Rows[d].Cells[1].Value.ToString();
            inpGT.Text = listNV.Rows[d].Cells[2].Value.ToString();
            inpHSLuong.Text = listNV.Rows[d].Cells[3].Value.ToString();
            inpMaDV.Text = listNV.Rows[d].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putSring = string.Format("?ma={0}&ten={1}&gioitinh={2}&hsluong={3}&madv={4}",
                inpMa.Text, inpTen.Text, inpGT.Text, inpHSLuong.Text, inpMaDV.Text);
            string link = "https://localhost:44314/api/nhanvien" + putSring;

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";

            Stream dataStream = request.GetRequestStream();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Sua thành công");
            }
            else
            {
                MessageBox.Show("Sua thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string deleteString = string.Format("?ma={0}", inpMa.Text);
            string link = "https://localhost:44314/api/nhanvien" + deleteString;

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string link = "https://localhost:44314/api/nhanvien?gt=" + inpGT.Text;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] arr = data as NhanVien[];
            listNV.DataSource = arr;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTimHS_Click(object sender, EventArgs e)
        {
            string link = "https://localhost:44314/api/nhanvien?start=" + inpStart.Text + "&end=" + inpEnd.Text;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] arr = data as NhanVien[];
            listNV.DataSource = arr;
        }
    }
}
