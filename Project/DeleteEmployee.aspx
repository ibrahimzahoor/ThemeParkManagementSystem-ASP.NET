<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DeleteEmployee.aspx.cs" Inherits="Project.DeleteEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="attractionsdetails" style=" margin: 0 auto; height:800px; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px; margin: 0 auto;">
                
                <br /><br />
                    <h3>DELETE EMPLOYEE</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE EMPLOYEE:</b></td>
                            <td><asp:DropDownList ID="DropDownList3" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                        <td><asp:Button ID="Button2" class="button" runat="server" Text="DELETE" 
                                    onclick="BtnEmpDelete_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Sucessfully Deleted Employee...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="Label2" runat="server" ForeColor="Red" Text="ERROR...Cannot Delete...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

                    <h2>DELETE DUTIES OF EMPLOYEES</h2>
                    <br />
                    <h3>DELETE DUTIES OF EMPLOYEES FOR RIDES</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE RIDE:</b></td>
                            <td><asp:DropDownList ID="DropDownRide" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE EMPLOYEES:</b></td>
                            <td><asp:DropDownList ID="DropDownEmployee" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr><td><asp:Button ID="Button5" class="button" Height="40px" runat="server" Text="DELETE" onclick="BtnEmpRideDelete_Click" /></td></tr>
                        <tr><td><asp:Label ID="LabelDuty_Ride" runat="server" ForeColor="Red" Text="Sucessfully DELETED Duty...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelDutyInvalid_Ride" runat="server" ForeColor="Red" Text="ERROR...Cannot DELETE...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

                
                <br />
                <br />
                    <h3>DELETE DUTIES OF EMPLOYEES FOR SHOWS</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE SHOW:</b></td>
                            <td><asp:DropDownList ID="DropDownShow" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE EMPLOYEES:</b></td>
                            <td><asp:DropDownList ID="DropDownEmployeeNEW" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr><td><asp:Button ID="Button1" class="button" Height="40px" runat="server" Text="DELETE" onclick="BtnEmpShowDelete_Click" /></td></tr>
                        
                        <tr><td><asp:Label ID="LabelDuty_Show" runat="server" ForeColor="Red" Text="Sucessfully DELETED Duty...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelDutyInvalid_Show" runat="server" ForeColor="Red" Text="ERROR...Cannot Delete...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

            </ div>
        </ div>

</asp:Content>
