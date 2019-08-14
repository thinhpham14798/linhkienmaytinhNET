<%@ Page Title="" Language="C#" MasterPageFile="~/admin/ViewAdmin.Master" AutoEventWireup="true" CodeBehind="qlchuyenmuc.aspx.cs" Inherits="LinhKien.admin.qlchuyenmuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title"><b>Danh sách danh mục</b> | <a href="themchuyenmuc.aspx" style="color:red;">Thêm danh mục mới</a></div>
    <asp:GridView ID="data" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="data_RowCommand">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="Mã danh mục" DataField="MaDanhMuc"/>
            <asp:BoundField HeaderText="Tên danh mục" DataField="TenDanhMuc"/>
            <asp:TemplateField HeaderText="Control">
                <ItemTemplate>
                    <asp:ImageButton ID="btnEdit" runat="server" ImageUrl="edit.png" CommandName="Sua" CommandArgument='<%# Eval("MaDanhMuc") %>' />
                    <asp:ImageButton ID="btnDel" runat="server" ImageUrl="del.png" CommandName="Xoa" CommandArgument='<%# Eval("MaDanhMuc") %>' CausesValidation="false" OnClientClick='return confirm("Bạn chắc chắn muốn xóa chứ?");' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
</asp:Content>
