using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien
{
    
    public partial class GioHang : System.Web.UI.Page
    {
        static DataTable tbGioHang = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_data();
            }
        }
        private void load_data()
        {
            if (Request.QueryString["ProID"] != null)
            {
                int idSP = int.Parse(Request.QueryString["ProID"]);
                KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
                DataTable dt = ketNoiCSDL.ThucThiLenhTraVeBang("select TenSanPham,Gia From SanPham WHERE MaSanPham =" + idSP);
                String TenSP = dt.Rows[0][0].ToString();
                int Dongia = int.Parse(dt.Rows[0][1].ToString());
                int Soluong = 1;
                ThemVaoGioHang(idSP, TenSP, Dongia, Soluong);
            }
            if (Session["GioHang"] == null)
            {
                Response.Redirect("GioHangRong.aspx");
            }
            tbGioHang = (DataTable)Session["GioHang"];
            var result = tbGioHang.AsEnumerable().Sum(x => Convert.ToInt32(x["ThanhTien"]));
            lblTongTien.Text = "Thành tiền: "+result.ToString()+"đ";
            gvGioHang.DataSource = tbGioHang;
            gvGioHang.DataBind();
        }
        public void ThemVaoGioHang(int idSP, string TenSP, int Dongia, int Soluong)
        {
            DataTable dt;
            if (Session["GioHang"] == null)
            {
                dt = new DataTable();
                dt.Columns.Add("idSP");
                dt.Columns.Add("TenSP");
                dt.Columns.Add("Gia");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("ThanhTien");
            }
            else
                dt = (DataTable)Session["GioHang"];
            int dong = SPdacotronggiohang(idSP, dt);
            if (dong != -1)
            {
                dt.Rows[dong]["SoLuong"] = Convert.ToInt32(dt.Rows[dong]["SoLuong"]) + Soluong;
                dt.Rows[dong]["ThanhTien"] = Convert.ToInt32(dt.Rows[dong]["SoLuong"])* Convert.ToInt32(dt.Rows[dong]["Gia"]);
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["idSP"] = idSP;
                dr["TenSP"] = TenSP;
                dr["Gia"] = Dongia;
                dr["SoLuong"] = Soluong;
                dr["ThanhTien"] = Dongia * Soluong;
                dt.Rows.Add(dr);
            }
            Session["GioHang"] = dt;
        }
        public static int SPdacotronggiohang(int idSP, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["idSP"].ToString()) == idSP)
                {
                    dong = i;
                    break;
                }
            }
            return dong;
        }

        protected void gvGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xoa")
            {
                int chiso = int.Parse(e.CommandArgument.ToString());
                try
                {
                    DataTable dt = (DataTable)Session["GioHang"];
                    dt.Rows.RemoveAt(chiso);
                    Session["GioHang"] = dt;
                    Response.Redirect("~/GioHang.aspx");
                }
                catch
                {
                    Response.Redirect("~/GioHang.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ThanhToan.aspx");
        }
    }

}