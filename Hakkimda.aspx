<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Hakkimda.aspx.cs" Inherits="Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="about-section">
            <h3>HAKKIMIZDA</h3>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <p><%# Eval("HAKKIMDA") %></p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

