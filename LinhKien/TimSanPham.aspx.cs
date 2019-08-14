using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public partial class TimSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "Select MaSanPham,TenSanPham,HinhAnh,SUBSTRING(MoTa, 0, 56)+'...' as MoTa,Gia, SLCon,SLBan,NgayBan from SanPham where TenSanPham like '%" + txtTuKhoa.Text + "%'";
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            DataTable dt = ketNoi.ThucThiLenhTraVeBang(sql);
            dataSanPham.DataSource = dt;
            dataSanPham.DataBind();
        }
    }
}