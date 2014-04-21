<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="RideGrid.aspx.cs" Inherits="Project.RideGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="attractionsdetails" style="height:800px; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px;margin:0 auto;">
                
                <br /><br />
             <h2 style="margin:0 auto;">RIDE DETAILS</h2>
                <br />
                    <asp:PlaceHolder ID="PlaceHolderRide" runat="server" EnableViewState="true" />                
                 
                
                   <asp:PlaceHolder ID="PlaceHolderRide1" runat="server" EnableViewState="true" />                
                 
            </ div>
        </ div>
</asp:Content>
