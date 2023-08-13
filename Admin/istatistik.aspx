<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="istatistik.aspx.cs" Inherits="Admin_istatistik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="table table-bordered">
        <tr>
            <td>Toplam Blog Sayısı: 
                <asp:Label ID="LblBlog" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Toplam Yorum Sayısı: 
                <asp:Label ID="LblYorum" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Flim Sayısı: 
                <asp:Label ID="LblFlim" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Dizi Sayısı: 
                <asp:Label ID="LblDizi" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Animasyon Sayısı:  
                <asp:Label ID="LblAnimasyon" runat="server" Text="Label"></asp:Label>
            </td>
            <td>En Fazla Yorumlu Blogg:  
                <asp:Label ID="LblYorumBlog" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

