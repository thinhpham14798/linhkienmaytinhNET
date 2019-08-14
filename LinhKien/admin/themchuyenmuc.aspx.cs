using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class themchuyenmuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string TenDanhMuc = txtTenDanhMuc.Text;
                DanhMuc danhMuc = new DanhMuc
                {
                    Tendanhmuc = TenDanhMuc
                };
                DanhMucDAO DAO = new DanhMucDAO();
                if (DAO.ThemDanhMuc(danhMuc))
                {
                    lblThongBao.Text = "Thêm danh mục thành công.";
                }
                else
                {
                    lblThongBao.Text = "Có lỗi trong quá trình thêm. Liên hệ DEV";
                }

            }
        }
    }
}