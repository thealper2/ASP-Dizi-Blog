<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="YorumGuncelle.aspx.cs" Inherits="Admin_YorumGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" class="form-group">
        <asp:TextBox ID="TxtBaslik" runat="server" placeholder="Başlık" Enabled="false" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtKullanici" runat="server" placeholder="Kullanıcı Ad" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtIcerik" runat="server" placeholder="Yorum Icerik" CssClass="form-control" Height="150px" TextMode="MultiLine" OnTextChanged="TxtIcerik_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="BtnKayit" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="BtnKayit_Click" />
    </form>
</asp:Content>

