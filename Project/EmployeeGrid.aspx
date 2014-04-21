<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="EmployeeGrid.aspx.cs" Inherits="Project.EmployeeGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="attractionsdetails" style="height:800px; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px;margin:0 auto;">
                

                <br /><br />
                
                <br /><br />
             <h2 style="margin:0 auto;">EMPLOYEE DETAILS</h2>
                <br />
                    <asp:PlaceHolder ID="PlaceHolderEmployee" runat="server" EnableViewState="true" />                
                 
            </ div>
        </ div>

</asp:Content>
