using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinhKien.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KetNoiCSDL ketNoi = new KetNoiCSDL();
            string sql = @"select count(*) from admin where Username = @user and Password = @pass";
            ketNoi.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, ketNoi.LayKetNoi);
            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
            int result = (int)cmd.ExecuteScalar();
            if(result>=1)
            {
                Session["login"] = txtUsername.Text;
                Response.Redirect("index.aspx");
            }
            else
            {
                lblThongBao.Text = "Sai mật khẩu hoặc tài khoản!!!";
            }
        }
    }
}