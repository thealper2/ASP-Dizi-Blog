<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="hakkimdaGuncelle.aspx.cs" Inherits="Admin_hakkimdaGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" class="form-group">
        <br />
        <asp:TextBox ID="TxtIletisim" runat="server" placeholder="İletişim Açıklama" CssClass="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtHakkimda" runat="server" placeholder="Hakkımda" CssClass="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="BtnKayit" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="BtnKayit_Click" />
    </form>
</asp:Content>

