using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!Page.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        public void LoadDuLieu()
        {
            string sql = "select * From DonHang INNER JOIN TrangThai ON DonHang.TrangThai= TrangThai.TT where TrangThai=0 or TrangThai=1";
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            DataTable dt = ketNoi.ThucThiLenhTraVeBang(sql);
            data.DataSource = dt;
            data.DataBind();
        }
    }
}