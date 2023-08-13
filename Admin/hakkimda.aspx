<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="hakkimda.aspx.cs" Inherits="Admin_hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>ILETISIM ACIKLAMA</th>
            <th>GUNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("iletisimAciklama") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl=' <%# "hakkimdaGuncelle.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr>
            <th>ID</th>
            <th>HAKKIMIZDA</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("HAKKIMDA") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl=' <%# "hakkimdaGuncelle.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>

