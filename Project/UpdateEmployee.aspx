<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateEmployee.aspx.cs" Inherits="Project.UpdateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="attractionsdetails" style=" margin: 0 auto; height:auto; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px; margin: 0 auto;">
                
                <br /><br />
                    <h3 style="text-align:center">UPDATE DUTIES OF EMPLOYEES FOR RIDES</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE RIDE:</b></td>
                            <td><asp:DropDownList ID="DropDown_RideNEW" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE EMPLOYEES:</b></td>
                            <td><asp:DropDownList ID="DropDownEmployee_RideNEW" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>DUTY:</b></td>
                            <td><asp:TextBox ID="TextDuty_RideNEW" placeholder="Enter Duty" runat="server" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Button ID="Button2" class="button" runat="server" Text="UPDATE" 
                                    onclick="BtnEmpRideDuty_Update_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="LabelDuty_RideNEW" runat="server" ForeColor="Red" Text="Sucessfully Updated Duty...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelDutyInvalid_RideNEW" runat="server" ForeColor="Red" Text="ERROR...Cannot Update...!!" Visible="false"></asp:Label></td></tr> 
                    </table>
                
                
                <h3 style="text-align:center">UPDATE DUTIES OF EMPLOYEES FOR SHOWS</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE SHOW:</b></td>
                            <td><asp:DropDownList ID="DropDown_ShowNEW" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE EMPLOYEES:</b></td>
                            <td><asp:DropDownList ID="DropDownEmployee_ShowNEW" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>DUTY:</b></td>
                            <td><asp:TextBox ID="TextDuty_ShowNEW" placeholder="Enter Duty" runat="server" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Button ID="Button3" class="button" runat="server" Text="UPDATE" 
                                    onclick="BtnEmpShowDuty_Update_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="LabelDuty_ShowNEW" runat="server" ForeColor="Red" Text="Sucessfully Updated Duty...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelDutyInvalid_ShowNEW" runat="server" ForeColor="Red" Text="ERROR...Cannot Update...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

                        
            </ div>
        </ div>

</asp:Content>
