<%@ Page Title="View Requests" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewRequests.aspx.cs" Inherits="WebApp.ViewRequests" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Check requests</h2>
    <asp:Button ID="ButtonApproved" runat="server" Text="Approved for next train" OnClick="ShowApprovedRequestsForNextTrain" />
    <asp:Button ID="ButtonAll" runat="server" Text="All" OnClick="ShowAllRequests"/>
    <asp:Button ID="Button1" runat="server" Text="All for next train" OnClick="ShowRequestsForNextTrain"/>
    <asp:DropDownList ID="DropDownListTrains" runat="server"></asp:DropDownList>
    <br />

    <asp:Table ID="TableRequests" 
        GridLines="Both" 
        HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0"
        runat="server">
    </asp:Table>

    <asp:Button ID="ButtonDownLoadTable" runat="server" Text="DownLoad Table" OnClick="DownloadTable" />


</asp:Content>
