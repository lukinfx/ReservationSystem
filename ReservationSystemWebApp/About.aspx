<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="ReservationSystemWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Send request</h2>

    <form action="/action_page.php">
        <label for="name">Name:</label><br>
        <input type="text" id="name" name="name" value="John"><br>
        <input type="submit" value="Submit" onclick="Submit()">
    </form>

    <script
        function Submit()
        {
            
        }
    </script>
</asp:Content>
