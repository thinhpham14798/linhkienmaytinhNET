using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public class DonHangDAO
    {
        public bool ThemDonHang(DonHang donHang)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "DonHang_Insert";
            sqldata.InsertParameters.Add("NgayMua", donHang.ngayMua.ToString());
            sqldata.InsertParameters.Add("HoTen", donHang.HoTen.ToString());
            sqldata.InsertParameters.Add("SDT", donHang.SDT.ToString());
            sqldata.InsertParameters.Add("Email", donHang.Email.ToString());
            sqldata.InsertParameters.Add("DiaChi", donHang.diaChi.ToString());
            sqldata.InsertParameters.Add("Note", donHang.Note.ToString());

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
        public bool ThemHang(string maDH, string maSP, string sl)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.InsertCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.InsertCommand = "ChiTietDonHang_Insert";
            sqldata.InsertParameters.Add("MaDH", maDH);
            sqldata.InsertParameters.Add("MaSP", maSP);
            sqldata.InsertParameters.Add("SL", sl);
            
            try
            {
                sqldata.Insert();
                string sql= "update SanPham set SLCon=SLCon-"+sl+", SLBan=SLBan+"+sl+" where MaSanPham="+maSP;
                chuoiketnoi.Xoa(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaDH(string id)
        {
            SqlDataSource sqldata = new SqlDataSource();
            KetNoiCSDL chuoiketnoi = new KetNoiCSDL();
            sqldata.ConnectionString = chuoiketnoi.GetSetChuoiKetNoi;
            sqldata.DeleteCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.DeleteCommand = "DonHang_Delete";
            sqldata.DeleteParameters.Add("MaDH", id);
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

    }
}