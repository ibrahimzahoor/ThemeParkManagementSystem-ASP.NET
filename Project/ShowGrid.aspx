<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ShowGrid.aspx.cs" Inherits="Project.ShowGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="attractionsdetails" style="height:800px; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px;margin:0 auto;">
                
                <br /><br />
             <h2 style="margin:0 auto;">SHOW DETAILS</h2>
                    <asp:PlaceHolder ID="PlaceHolderShow" runat="server" EnableViewState="true" />                
                 
            </ div>
        </ div>
</asp:Content>
