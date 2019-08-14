using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinhKien
{
    public class DonHang
    {
        private int _maDH;
        public int MaDH
        {
            get { return _maDH; }
            set { _maDH = value; }
        }
        private string _hoTen;
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private DateTime _ngayMua;
        public DateTime ngayMua
        {
            get { return _ngayMua; }
            set { _ngayMua = value; }
        }
        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _diaChi;
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _note;
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        private int _trangThai;
        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
        public DonHang()
        {
        }
    }
}