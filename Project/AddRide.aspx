<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddRide.aspx.cs" Inherits="Project.AddRIDE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="attractionsdetails" style=" margin: 0 auto; height:auto; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px; margin: 0 auto;">
                
                <br /><br />
             
                    <h3>ADD NEW RIDES</h3>
                    <table>
                        <tr><td><asp:Label ID="Label" runat="server" ForeColor="Red" Text="MUST FILL RIDE NAME...!! " Visible="false"></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Sucessfully ADDED RIDE...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="Label2" runat="server" ForeColor="Red" Text="ERROR...Cannot ADD...!!" Visible="false"></asp:Label></td></tr> 
                    
                        <tr>
                            <td><b>RIDE NAME:</b></td>
                            <td><asp:TextBox ID="name" placeholder="Enter NAME" runat="server" TextMode="SingleLine"   
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        
                        <tr>
                            <td><b>TICKET PRICE:</b></td>
                            <td><asp:TextBox ID="price" placeholder="Enter PRICE" runat="server" TextMode="Number"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        
                        <tr>
                            <td><b>NO. OF PERSONS:</b></td>
                            <td><asp:TextBox ID="persons" placeholder="Enter NUMBER" runat="server" TextMode="Number"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                    
                            <tr>
                            <td><b>AGE LIMIT:</b></td>
                            <td><asp:TextBox ID="age" placeholder="Enter AGE-LIMIT" runat="server" TextMode="Number"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><b>CHOOSE AREA:</b></td>
                            <td><asp:DropDownList ID="DropDownArea" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE MANAGER:</b></td>
                            <td><asp:DropDownList ID="DropDownManager" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>

                        <tr>
                            <td><asp:Button ID="Button3" class="button" runat="server" Text="ADD" 
                                    onclick="BtnRideAdd_Click" Height="40px" /></td></tr>

                    
                    </table>

            </ div>
        </ div>
    <br />
    <br />
    <br />

</asp:Content>