<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Send Request</h2>
    

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Sumbit" OnClick="AddRequest"/>

    <asp:Label ID="Label1" runat="server" Text="Last Request:"></asp:Label>
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Last request" OnClick="LastRequest" />

    

</asp:Content>
