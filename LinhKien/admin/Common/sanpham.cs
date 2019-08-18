using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinhKien
{
    public class sanpham
    {
        private int _maSP;
        public int MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }
        private string _tenSP;
        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }
        private DateTime _ngayBan;
        public DateTime ngayBan
        {
            get { return _ngayBan; }
            set { _ngayBan = value; }
        }
        private int _gia;
        public int GiaBan
        {
            get { return _gia; }
            set { _gia = value; }
        }
        private int  _slcon;
        public int SLCon
        {
            get { return _slcon; }
            set { _slcon = value; }
        }
        private int _slBan;
        public int SLBan
        {
            get { return _slBan; }
            set { _slBan = value; }
        }
        private string _hinh;
        public string HinhAnh
        {
            get { return _hinh; }
            set { _hinh = value; }
        }
        private int _maDanhMuc;
        public int MaDanhMuc
        {
            get { return _maDanhMuc; }
            set { _maDanhMuc = value; }
        }
        private string _moTa;
        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        public sanpham()
        {
        }
    }
}