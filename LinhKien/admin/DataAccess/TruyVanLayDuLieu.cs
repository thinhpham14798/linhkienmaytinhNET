using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public class TruyVanLayDuLieu
    {
        private DanhMuc _danhMuc;
        public DanhMuc Danhmuc
        {
            get { return _danhMuc; }
            set { _danhMuc = value; }
        }
        public SqlDataSource Laydulieu(string procedue)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = procedue;
            return sqldata;
        }
        public SqlDataSource LaydulieubyID(string GiaTriParaMetter, string TenThuTuc, string TenParametter)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = TenThuTuc;
            sqldata.SelectParameters.Add(TenParametter, GiaTriParaMetter);
            return sqldata;
        }
    }
}