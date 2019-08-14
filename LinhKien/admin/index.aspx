<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ViewAdmin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LinhKien.admin.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="title"><b>Đơn đặt chưa giao</b></div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField HeaderText="Mã ĐH" />
            <asp:BoundField HeaderText="Mã SP" />
            <asp:BoundField HeaderText="Số lượng" />
            <asp:BoundField HeaderText="Người đặt" />
            <asp:BoundField HeaderText="Địa chỉ giao" />
            <asp:BoundField HeaderText="Thành tiền" />
            <asp:BoundField HeaderText="Thời gian đặt" />
            <asp:BoundField HeaderText="Trạng thái" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</asp:Content>
