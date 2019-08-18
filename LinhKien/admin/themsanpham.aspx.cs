using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class themsanpham : System.Web.UI.Page
    {
        int index = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LoadDanhMuc();
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

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && FileUpload1.HasFile)
            {
                string fileName = DateTime.Now.ToString("ddMMyyyy_hhmmss_tt_")+FileUpload1.FileName;
                string filePath = MapPath("~/images/"+fileName);
                FileUpload1.SaveAs(filePath);
                Image1.ImageUrl = fileName;
                sanpham sp = new sanpham
                {
                    TenSP = txtTenSP.Text,
                    MoTa = txtMoTa.Text,
                    HinhAnh = fileName,
                    GiaBan = int.Parse(txtGiaBan.Text),
                    SLCon = int.Parse(txtSLBan.Text),
                    MaDanhMuc = int.Parse(chuyenmuc.SelectedValue.ToString()),
                    ngayBan = DateTime.Now
                   
                };
                SanPhamDAO DAO = new SanPhamDAO();
                if (DAO.ThemSP(sp))
                    lblThongBao.Text = "Thêm sản phẩm thành công!!";
                else
                    lblThongBao.Text = "Thêm sản phẩm bị lỗi...";
            }
        }

        protected void chuyenmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}