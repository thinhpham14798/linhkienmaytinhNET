using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        DataTable tbGioHang = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["GioHang"] == null)
            {
                Response.Redirect("GioHangRong.aspx");
            }

            tbGioHang = (DataTable)Session["GioHang"];
            string strnumber = tbGioHang.AsEnumerable().Sum(x => Convert.ToInt32(x["ThanhTien"])).ToString();
            lblTongTien.Text = "Tổng tiền: "+strnumber+"đ";
            gvDatHang.DataSource = tbGioHang;
            gvDatHang.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                String hoTen = txtHoTen.Text;
                String SDT = txtSDT.Text;
                String email = txtEmail.Text;
                String diaChi = txtDiaChi.Text;
                String note = txtNote.Text;
                DonHang donHang = new DonHang
                {
                    ngayMua = DateTime.Now,
                    HoTen = hoTen,
                    SDT = SDT,
                    Email = email,
                    diaChi = diaChi,
                    Note = note
                };
                DonHangDAO DAO = new DonHangDAO();
                if (!DAO.ThemDonHang(donHang))
                    Response.Write("Lỗi khi khởi tạo đơn hàng!!!!");
                else
                {
                    String sql = "SELECT IDENT_CURRENT('DonHang') as LastID";
                    KetNoiCSDL ketNoi = new KetNoiCSDL();
                    DataTable dt = ketNoi.ThucThiLenhTraVeBang(sql);
                    string maDH = dt.Rows[0][0].ToString();
                    if (tbGioHang.Rows.Count > 0)
                    {
                        foreach (DataRow r in tbGioHang.Rows)
                        {
                            string idSP = r["idSP"].ToString();
                            string SoLuong = r["SoLuong"].ToString();
                            DAO.ThemHang(maDH, idSP, SoLuong);

                        }
                        
                        Session["GioHang"] = null;
                        Response.Write("Đặt hàng thành công!!!!");
                    }
                }
            }
            
        }
    }
}