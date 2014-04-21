<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DeleteShow.aspx.cs" Inherits="Project.DeleteShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="attractionsdetails" style=" margin: 0 auto; height:800px; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px; margin: 0 auto;">
                
                <br /><br />
                    <h3>DELETE SHOWS</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE SHOW:</b></td>
                            <td><asp:DropDownList ID="DropDownShow" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                        <td><asp:Button ID="Button2" class="button" runat="server" Text="DELETE" 
                                    onclick="BtnShowDelete_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Sucessfully Deleted Employee...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="Label2" runat="server" ForeColor="Red" Text="ERROR...Cannot Delete...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

               
            </ div>
        </ div>

</asp:Content>
