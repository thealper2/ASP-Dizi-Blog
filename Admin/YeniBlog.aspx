<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="YeniBlog.aspx.cs" Inherits="Admin_YeniBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" class="form-group">
        <asp:TextBox ID="TxtBaslik" runat="server" placeholder="Başlik" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtTarih" runat="server" placeholder="Tarıh" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtGorsel" runat="server" placeholder="Görsel" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="TURAD" DataValueField="TURID"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataTextField="KATEGORIAD" DataValueField="KATEGORIID"></asp:DropDownList>
        <br />
        <asp:TextBox ID="TxtIcerik" runat="server" placeholder="İçerik" CssClass="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="BtnKayit" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="BtnKayit_Click" />
    </form>
</asp:Content>

