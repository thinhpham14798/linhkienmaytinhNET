using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadSanPham();
        }
        private void LoadSanPham()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataSanPham.DataSource = dao.Laydulieu("SanPham_Select");
            dataSanPham.DataBind();
        }
    }
}