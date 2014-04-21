<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateShow.aspx.cs" Inherits="Project.UpdateShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div id="attractionsdetails" style=" margin: 0 auto; height:800px; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px; margin: 0 auto;">
                
                <br /><br />
             
                    <h2 style="text-align:center">UPDATE SHOW DETAILS</h2>
                    <table>
                        <tr>
                            <td><b>CHOOSE SHOW:</b></td>
                            <td><asp:DropDownList ID="DropDownShow" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>TICKET PRICE:</b></td>
                            <td><asp:TextBox ID="TextPrice" TextMode="Number" Text="0" runat="server" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Button ID="Button1" class="button" runat="server" Text="UPDATE" 
                                    onclick="BtnPrice_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="LabelPrice" runat="server" ForeColor="Red" Text="Sucessfully Updated Price...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelPriceInvalid" runat="server" ForeColor="Red" Text="ERROR...Cannot Update...!!" Visible="false"></asp:Label></td></tr> 
                    
                        <tr>
                            <td><b>NO. OF PERSONS:</b></td>
                            <td><asp:TextBox ID="TextPersons" TextMode="Number" Text="0" runat="server" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Button ID="Button4" class="button" Height="40px" runat="server" Text="UPDATE" onclick="BtnPersons_Click" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="LabelPersons" runat="server" ForeColor="Red" Text="Sucessfully Updated Number of Persons Allowed...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelPersonsInvalid" runat="server" ForeColor="Red" Text="ERROR...Cannot Update...!!" Visible="false"></asp:Label></td></tr> 
                    
                   </table>

                
            </ div>
        </ div>
</asp:Content>
