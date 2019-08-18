using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class suadonhang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Write("qldonhang.aspx");
            if (!this.IsPostBack)
            {
                LoadTrangThai();
                LoadDuLieu();
            }
        }
        private void LoadTrangThai()
        {
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            trangthai.DataSource = ketNoi.ThucThiLenhTraVeBang("Select * from TrangThai");
            trangthai.DataTextField = "Name";
            trangthai.DataValueField = "TT";
            trangthai.DataBind();
        }
        private void LoadDuLieu()
        {
            string id = Request.QueryString["id"];
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            GridView gr = new GridView();
            gr.DataSource = ketNoi.ThucThiLenhTraVeBang("SELECT * From DonHang where MaDH="+id);
            gr.DataBind();
            if (gr.Rows.Count > 0)
            {
                txtMaDH.Text = gr.Rows[0].Cells[0].Text;
                txtNgayDat.Text = gr.Rows[0].Cells[1].Text;
                txtNgayDat.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[2].Text.ToString()));
                txtSDT.Text = gr.Rows[0].Cells[3].Text;
                txtEmail.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[4].Text.ToString()));
                txtDiaChi.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[5].Text.ToString()));
                txtGhiChu.Text = HttpUtility.HtmlDecode((string)(gr.Rows[0].Cells[6].Text.ToString()));
                trangthai.SelectedIndex = int.Parse(gr.Rows[0].Cells[7].Text);
            }
            gvDatHang.DataSource = ketNoi.ThucThiLenhTraVeBang("SELECT MaSP, TenSanPham, SL,Gia, (SL*Gia) as ThanhTien From DonHang INNER JOIN ChiTietDonHang ON DonHang.MaDH= ChiTietDonHang.MaDH INNER JOIN SanPham ON ChiTietDonHang.MaSP= SanPham.MaSanPham WHERE DonHang.MaDH=" + id);
            gvDatHang.DataBind();
            string strnumber = ketNoi.ThucThiLenhTraVeBang("SELECT MaSP, TenSanPham, SL, (SL*Gia) as ThanhTien From DonHang INNER JOIN ChiTietDonHang ON DonHang.MaDH= ChiTietDonHang.MaDH INNER JOIN SanPham ON ChiTietDonHang.MaSP= SanPham.MaSanPham WHERE DonHang.MaDH=" + id).AsEnumerable().Sum(x => Convert.ToInt32(x["ThanhTien"])).ToString();
            txtTongTien.Text = strnumber + "đ";
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            string sql = " Update DonHang Set TrangThai=" + trangthai.SelectedValue.ToString() + " where MaDH=" + id;
            if (ketNoi.Lenh(sql))
                lblThongBao.Text = "Cập nhật trang thái đơn hàng thành công!!";
            else
                lblThongBao.Text = "Có lỗi xãy ra!!!";
        }
    }
}