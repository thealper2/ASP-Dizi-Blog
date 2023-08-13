<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Mesajlar.aspx.cs" Inherits="Admin_Mesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
            <th>MAIL</th>
            <th>TELEFON</th>
            <th>KONU</th>
            <th>MESAJ</th>
            <th>SIL</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("MESAJID") %></td>
                    <td><%# Eval("ADSOYAD") %></td>
                    <td><%# Eval("MAIL") %></td>
                    <td><%# Eval("TELEFON") %></td>
                    <td><%# Eval("KONU") %></td>
                    <td><%# Eval("MESAJ") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "MesajSil.aspx?MESAJID=" + Eval("MESAJID") %>'>Sil</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>

