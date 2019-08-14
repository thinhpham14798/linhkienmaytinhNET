using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class qlchuyenmuc : System.Web.UI.Page
    {
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            data.DataSource = dao.Laydulieu("DanhMuc_Select");
            data.DataBind();
        }
        protected void data_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Sua")
            {
                id = (string)e.CommandArgument;
                Response.Redirect("suachuyenmuc.aspx?id=" + id);
            }
            else
            {
                id = (string)e.CommandArgument;
                DanhMucDAO DAO = new DanhMucDAO();
                DAO.XoaDanhMuc(id);
                LoadDuLieu();
            }
        }
    }
}