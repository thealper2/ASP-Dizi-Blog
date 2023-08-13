<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="BlogDetay.aspx.cs" Inherits="BlogDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!DOCTYPE HTML>
    <html>
    <head>
        <title></title>
        <link href="~/web/css/bootstrap.css" rel='stylesheet' type='text/css' />
        <link href="~/web/css/style.css" rel='stylesheet' type='text/css' />
        <link href="~/web/css/media.css" rel="stylesheet" />
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta name="keywords" content="Personal Blog Responsive web template, Bootstrap Web Templates, Flat Web Templates, Andriod Compatible web template, 
	    Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <!----webfonts---->
        <link href='http://fonts.googleapis.com/css?family=Oswald:100,400,300,700' rel='stylesheet' type='text/css'>
        <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900,300italic' rel='stylesheet' type='text/css'>
        <!----//webfonts---->
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
        <!--end slider -->
        <!--script-->
        <script type="~/web/text/javascript" src="js/move-top.js"></script>
        <script type="~/web/text/javascript" src="js/easing.js"></script>
        <!--/script-->
        <script type="text/javascript">
            jQuery(document).ready(function ($) {
                $(".scroll").click(function (event) {
                    event.preventDefault();
                    $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 900);
                });
            });
        </script>
        <!---->

    </head>
    <body>

        <div class="single">
            <div class="container">
                <div class="col-md-8 single-main">
                    <div class="single-grid">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <img class="infoimg" src="<%#Eval("BLOGGORSEL")%>" alt="" /><br />
                                <br />
                                <h3><%# Eval("BLOGBASLIK") %></h3>
                                <p>
                                    <%#Eval("BLOGICERIK") %>
                                </p>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <ul class="comment-list">
                                <li>
                                    <img src="~/web/images/avatar.png" class="img-responsive" alt="">
                                    <div class="baslik">
                                        <p><%# Eval("KULLANICIAD") %>:</p>
                                        <p><%# Eval("YORUMICERIK") %></p>
                                    </div>
                                    <div class="clearfix"></div>
                                </li>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="content-form">
                        <h3>YORUM YAP</h3>
                        <form runat="server">
                            <asp:TextBox ID="TxtAd" runat="server" placeholder="Kullanıcı Adınız" required=""></asp:TextBox>
                            <asp:TextBox ID="TxtMail" runat="server" placeholder="Mail Adresiniz" required=""></asp:TextBox>
                            <asp:TextBox ID="TxtYorum" runat="server" placeholder="Yorumunuz" TextMode="MultiLine" Height="150" required=""></asp:TextBox>

                            <asp:Button ID="BtnYorum" runat="server" Text="Yorum Yap" OnClick="BtnYorum_Click" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
