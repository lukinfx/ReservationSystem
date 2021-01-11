<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="ReservationSystemWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Send request</h2>

    <form action="/action_page.php">
        <label for="fname">First name:</label><br>
        <input type="text" id="fname" name="fname" value="John"><br>
        <label for="lname">Last name:</label><br>
        <input type="text" id="lname" name="lname" value="Doe"><br><br>
        <input type="submit" value="Submit" onclick="Submit()">
    </form>

    <script
        function Submit()
        {
            
        }
    </script>
</asp:Content>
