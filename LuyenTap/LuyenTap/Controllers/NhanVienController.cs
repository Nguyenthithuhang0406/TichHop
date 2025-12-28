using LuyenTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LuyenTap.Controllers
{
    public class NhanVienController : ApiController
    {
        QLLuongEntities db = new QLLuongEntities();

        [HttpGet]
        public List<NhanVien> LayNhanViens()
        {
            return db.NhanViens.ToList();
        }

        [HttpGet]
        public List<NhanVien> LayNVTheoDonVi(int madv)
        {
            return db.NhanViens.Where(x => x.MaDonVi == madv).ToList();
        }

        [HttpGet]
        public List<NhanVien> LayNVTheoGT(string gt)
        {
            return db.NhanViens.Where(x => x.GioiTinh == gt).ToList();
        }

        [HttpGet]
        public List<NhanVien> LayNVTheoHSLuong(decimal start, decimal end)
        {
            return db.NhanViens.Where(x => x.HSLuong >= start && x.HSLuong <= end).ToList();
        }

        [HttpPost]
        public bool ThemNhanVien(int ma, string ten, string gioitinh, decimal hsluong, int madv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == ma);
            if (nv == null)
            {
                NhanVien nv1 = new NhanVien();
                nv1.MaNhanVien = ma;
                nv1.HoTen = ten;
                nv1.GioiTinh = gioitinh;
                nv1.HSLuong = hsluong;
                nv1.MaDonVi = madv;
                db.NhanViens.Add(nv1);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool SuaNhanVien(int ma, string ten, string gioitinh, decimal hsluong, int madv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == ma);
            if (nv != null)
            {
                nv.HoTen = ten;
                nv.GioiTinh = gioitinh;
                nv.HSLuong = hsluong;
                nv.MaDonVi = madv;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool XoaNhanVien(int ma)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNhanVien == ma);
            if (nv != null)
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
