using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class qldonhang : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] == null)
                Response.Redirect("login.aspx");
            if (!Page.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        public void LoadDuLieu()
        {
            string sql = "select * From DonHang INNER JOIN TrangThai ON DonHang.TrangThai= TrangThai.TT ORDER BY MaDH DESC";
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            DataTable dt = ketNoi.ThucThiLenhTraVeBang(sql);
            data.DataSource = dt;
            data.DataBind();
        }

        protected void data_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sua")
            {
                id = (string)e.CommandArgument;
                Response.Redirect("suadonhang.aspx?id=" + id);
            }
            else
            {
                id = (string)e.CommandArgument;
                DonHangDAO DAO = new DonHangDAO();
                DAO.XoaDH(id);
                LoadDuLieu();
            }
        }
    }
}