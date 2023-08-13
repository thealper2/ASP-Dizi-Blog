<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="web/css/login.css" rel="stylesheet" />
</head>
<body>
    <div class="loginBox">
        <img class="user" src="" alt="" />
        <h3>Filim Dizi Login Paneli</h3>
        <form action="login.aspx" method="post" runat="server">
            <div class="inputBox">
                <asp:TextBox ID="TxtAd" runat="server" placeholder="Kullanıcı Ad"></asp:TextBox>
                <asp:TextBox ID="TxtSifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Button ID="BtnGiris" runat="server" Text="Giriş Yap" OnClick="BtnGiris_Click1" />
        </form>
    </div>
</body>
</html>
