using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Redirect("~/index.aspx");
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        public void LoadDuLieu()
        {
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            DataTable dt = ketNoi.ThucThiLenhTraVeBang("Select * from SanPham where MaSanPham=" + Request.QueryString["id"].ToString());
            lblTenSP.Text = dt.Rows[0][1].ToString();
            lblMoTa.Text = dt.Rows[0][2].ToString();
            img.ImageUrl = "~/images/" + dt.Rows[0][3].ToString();
            lblGia.Text+= " " + dt.Rows[0][4].ToString() + "đ";
            lblSoLuongCon.Text = dt.Rows[0][5].ToString();
            lblSoLuongDaBan.Text = dt.Rows[0][6].ToString();
            lblNgayBan.Text = dt.Rows[0][8].ToString();
            HyperLink1.NavigateUrl = "~/GioHang.aspx?ProID=" + Request.QueryString["id"].ToString();
        }
    }
}