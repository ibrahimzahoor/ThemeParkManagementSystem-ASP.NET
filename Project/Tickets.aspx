<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="Project.Tickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="attractionsdetails" style="height:auto; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:700px; margin:0 auto;">
                
                <br /><br />
                    
                <br />
                    <table style="margin:0 auto;">
                        <tr><td><h2 style="margin:0 auto;">RIDE TICKETS PRICES</h2></td></tr>
                        <tr><td></td></tr>
                        <tr><td></td></tr>
                        <tr><td><asp:PlaceHolder ID="PlaceHolderRideTicket" runat="server" EnableViewState="true" /></td></tr>
                    </table>                
                <br /><br />
             
                
                <br />
                    <table style="margin:0 auto;">
                        <tr><td><h2 style="margin:0 auto;">SHOW TICKETS PRICES</h2></td></tr>
                        <tr><td></td></tr>
                        <tr><td></td></tr>
                        <tr><td><asp:PlaceHolder ID="PlaceHolderShowTicket" runat="server" EnableViewState="true" /></td></tr>
                    </table>                                
                <br />
                <br />
                <br />
                <br />
                <br />  
            </ div>
        </ div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
