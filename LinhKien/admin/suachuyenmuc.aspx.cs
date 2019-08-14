using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class suachuyenmuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("qldchuyenmuc.aspx");
            if (!this.IsPostBack)
            {
                LoadDuLieu();
            }
        }
        private void LoadDuLieu()
        {
            string id = Request.QueryString["id"];
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "DanhMucByID_Select", "MaDanhMuc");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtMaDanhMuc.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[0].Text.ToString()));
                txtTenDanhMuc.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
            }
            else
                Response.Redirect("qlchuyenmuc.aspx");
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string TenDanhMuc = txtTenDanhMuc.Text;
                DanhMuc danhMuc = new DanhMuc
                {
                    Iddanhmuc= int.Parse(Request.QueryString["id"]),
                    Tendanhmuc = TenDanhMuc
                };
                DanhMucDAO DAO = new DanhMucDAO();
                if (DAO.SuaDanhMuc(danhMuc))
                {
                    lblThongBao.Text = "Cập nhật thành công.";
                }
                else
                {
                    lblThongBao.Text = "Có lỗi trong quá trình sửa. Liên hệ DEV";
                }
            }

        }
    }
}