<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="KategoriDetay.aspx.cs" Inherits="KategoriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img class="infoimg" src="<%# Eval("BLOGGORSEL") %>" />
                                <div class="post-info">
                                    <h4><a href="BlogDetay.aspx?BLOGID=<%# Eval("BLOGID") %>"><%# Eval("BLOGBASLIK") %></a><%# Eval("BLOGTARIH") %></h4>
                                    <p><%# Eval("BLOGICERIK") %></p>
                                    <a href="single.html"><span></span>Devamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="col-md-4 content-right">
            <div class="recent">
                <h3>EN SON BLOGLAR</h3>
                <ul>
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <li><a href="#"><%# Eval("BLOGBASLIK") %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <div class="comments">
                <h3>SON YORUMLAR</h3>
                <ul>
                    <li><a href="#">Amada Doe </a>on <a href="#">Hello World!</a></li>
                    <li><a href="#">Peter Doe </a>on <a href="#">Photography</a></li>
                    <li><a href="#">Steve Robert </a>on <a href="#">HTML5/CSS3</a></li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>

