<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LinhKien.admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link rel="stylesheet" href="style.css" type="text/css" />
</head>
<body style="width:400px">
    <form id="form1" runat="server">
        <div class="maintxt">
            <div class="phdr"><b>Đăng nhập</b></div>
            <div class="gmenu">
                <p>
                    <asp:Label ID="lblThongBao" runat="server" ForeColor="Red"></asp:Label>
                </p>
                <p>
                    Tên người dùng:<br>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
                    Mật khẩu:<br>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClick="Button1_Click" />
                </p>
                <p></p>
            </div>
        </div>
    </form>
</body>
</html>
