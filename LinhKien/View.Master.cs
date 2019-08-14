using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public partial class View : System.Web.UI.MasterPage
    {
        static DataTable tbGioHang = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["GioHang"] != null)
                {
                    tbGioHang = Session["GioHang"] as DataTable;
                }
                else
                {
                    tbGioHang.Rows.Clear();
                    tbGioHang.Columns.Clear();
                    tbGioHang.Columns.Add("idSP", typeof(int));
                    tbGioHang.Columns.Add("TenSP", typeof(string));
                    tbGioHang.Columns.Add("Gia", typeof(double));
                    tbGioHang.Columns.Add("SoLuong", typeof(int));
                    tbGioHang.Columns.Add("ThanhTien", typeof(double), "SoLuong * Gia");
                }
                LoadDanhMuc();
            }
            
        }
        private void LoadDanhMuc()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            dataDanhMuc.DataSource = dao.Laydulieu("DanhMuc_Select");
            dataDanhMuc.DataBind();
        }
    }
}