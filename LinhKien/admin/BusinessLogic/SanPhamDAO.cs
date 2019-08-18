using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public class SanPhamDAO
    {
        public bool ThemSP(sanpham sp)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "SanPham_Insert";
            sqldata.InsertParameters.Add("TenSanPham", sp.TenSP.ToString());
            sqldata.InsertParameters.Add("MoTa", sp.MoTa.ToString());
            sqldata.InsertParameters.Add("HinhAnh", sp.HinhAnh.ToString());
            sqldata.InsertParameters.Add("Gia", sp.GiaBan.ToString());
            sqldata.InsertParameters.Add("SLCon", sp.SLCon.ToString());
            sqldata.InsertParameters.Add("MaDanhMuc", sp.MaDanhMuc.ToString());
            sqldata.InsertParameters.Add("NgayBan", sp.ngayBan.ToString());
            try
            {
                sqldata.Insert();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaSP(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "SanPham_Delete";
            sqldata.DeleteParameters.Add("MaSanPham", id);
            try
            {
                sqldata.Delete();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaSP(sanpham sanpham)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.UpdateCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.UpdateCommand = "SanPham_Update";
            sqldata.UpdateParameters.Add("MaSP", sanpham.MaSP.ToString());
            sqldata.UpdateParameters.Add("MaDanhMuc", sanpham.MaDanhMuc.ToString());
            sqldata.UpdateParameters.Add("MoTa", sanpham.MoTa.ToString());
            sqldata.UpdateParameters.Add("HinhAnh", sanpham.HinhAnh.ToString());
            sqldata.UpdateParameters.Add("Gia", sanpham.GiaBan.ToString());
            sqldata.UpdateParameters.Add("SLCon", sanpham.SLCon.ToString());
            sqldata.UpdateParameters.Add("TenSanPham", sanpham.TenSP.ToString());
            try
            {
                sqldata.Update();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}