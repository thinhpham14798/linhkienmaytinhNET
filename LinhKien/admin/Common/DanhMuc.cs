using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinhKien
{
    public class DanhMuc
    {
        private int _iddanhmuc;
        public int Iddanhmuc
        {
            get { return _iddanhmuc; }
            set { _iddanhmuc = value; }
        }
        private string _tendanhmuc;
        public string Tendanhmuc
        {
            get { return _tendanhmuc; }
            set { _tendanhmuc = value; }
        }
        public DanhMuc()
        {
        }
    }
}