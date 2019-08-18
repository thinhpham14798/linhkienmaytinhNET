using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class suasanpham : System.Web.UI.Page
    {
        string fileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("qlsanpham.aspx");
            if (!this.IsPostBack)
            {
                LoadDanhMuc();
                LoadDuLieu();
            }
        }
        private void LoadDanhMuc()
        {
            TruyVanLayDuLieu dao = new TruyVanLayDuLieu();
            chuyenmuc.DataSource = dao.Laydulieu("DanhMuc_Select");
            chuyenmuc.DataTextField = "TenDanhMuc";
            chuyenmuc.DataValueField = "MaDanhMuc";
            chuyenmuc.DataBind();
        }
        private void LoadDuLieu()
        {
            string id = Request.QueryString["id"];
            TruyVanLayDuLieu truyvan = new TruyVanLayDuLieu();
            GridView gr = new GridView();
            gr.DataSource = truyvan.LaydulieubyID(id, "SanPhamByID_Select", "MaSanPham");
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtMaSP.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[0].Text.ToString()));
                txtTenSP.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[1].Text.ToString()));
                txtMoTa.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[2].Text.ToString()));
                fileName = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[3].Text.ToString()));
                Image1.ImageUrl="~/images/"+ fileName;
                txtGiaBan.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[4].Text.ToString()));
                txtSLBan.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[5].Text.ToString()));
            }
            else
                Response.Redirect("qlchuyenmuc.aspx");
        }
        protected void btnSua_Click(object sender, EventArgs e)
        {
                
                if (FileUpload1.HasFile)
                {
                    fileName = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_") + FileUpload1.FileName;
                    string filePath = MapPath("~/images/" + fileName);
                    FileUpload1.SaveAs(filePath);
                    Image1.ImageUrl = fileName;
                }
                sanpham sp = new sanpham
                {
                    MaSP = int.Parse(txtMaSP.Text),
                    TenSP = txtTenSP.Text,
                    MoTa = txtMoTa.Text,
                    HinhAnh = fileName,
                    GiaBan = int.Parse(txtGiaBan.Text),
                    SLCon = int.Parse(txtSLBan.Text),
                    MaDanhMuc = int.Parse(chuyenmuc.SelectedValue.ToString()),

                };
                SanPhamDAO DAO = new SanPhamDAO();
                if (DAO.SuaSP(sp))
                    lblThongBao.Text = "Cập nhật thông tin sản phẩm thành công!!";
                else
                    lblThongBao.Text = "Cập nhật thông tin sản phẩm bị lỗi...";
        }
    }
}