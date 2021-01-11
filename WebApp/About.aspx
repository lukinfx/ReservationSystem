<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Send Request</h2>
    
   <div>  
            <table class="auto-style1">  
                <tr>  
                    <td>Name</td>  
                    <td>  
                        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Package description</td>  
                     <td> <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td>Package weight</td>  
                    <td>  
                        <asp:TextBox ID="TextBoxweight" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Select train</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownListDates" runat="server">  
                            
                        </asp:DropDownList>
                    </td>  
                </tr>  
                
                <tr>  
                    <td>E-Mail</td>  
                    <td>  
                        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="ButtonSubmit" runat="server" Text="Sumbit" OnClick="AddRequest"/> 
                    </td>  
                </tr>  
            </table>  
        </div>

    <asp:Label ID="LabelSubmitted" runat="server"/>

    

</asp:Content>
