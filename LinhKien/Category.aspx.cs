using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public partial class Category : System.Web.UI.Page
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
            DataTable dt = ketNoi.ThucThiLenhTraVeBang("Select * from SanPham where MaDanhMuc="+ Request.QueryString["id"].ToString());
            dataSanPham.DataSource = dt;
            dataSanPham.DataBind();
        }
    }
}