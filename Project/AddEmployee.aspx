<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="Project.AddEmployee1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="attractionsdetails" style=" margin: 0 auto; height:auto; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger;">
            <div id="internal" style="width:800px; margin: 0 auto;">
                
                <br /><br />
             
                    <h3>ADD NEW EMPLOYEE</h3>
                    <table>
                        <tr><td><asp:Label ID="Label" runat="server" ForeColor="Red" Text="*MUST FILL ...!! " Visible="false"></asp:Label></td></tr>
                        <tr><td><asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Sucessfully ADDED EMPLOYEE...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="Label2" runat="server" ForeColor="Red" Text="ERROR...Cannot ADD...!!" Visible="false"></asp:Label></td></tr> 
                        
                        <tr>
                            <td><b>NAME: (*)</b></td>
                            <td><asp:TextBox ID="name" placeholder="Enter NAME" runat="server" TextMode="SingleLine" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        
                        <tr>
                            <td><b>CNIC:(*)</b></td>
                            <td><asp:TextBox ID="cnic" placeholder="Enter CNIC" runat="server"  TextMode="Number"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        
                        <tr>
                            <td><b>SEX:(*)</b></td>
                            <td><asp:TextBox ID="sex" placeholder="Enter SEX" runat="server"  TextMode="SingleLine"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                    
                            <tr>
                            <td><b>ADDRESS:</b></td>
                            <td><asp:TextBox ID="address" placeholder="Enter ADDRESS" runat="server" TextMode="SingleLine" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        

                            <tr>
                            <td><b>SALARY:</b></td>
                            <td><asp:TextBox ID="Salary" placeholder="Enter SALARY" runat="server"  TextMode="Number"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="Button3" class="button" runat="server" Text="ADD" 
                                    onclick="BtnEmpAdd_Click" Height="40px" /></td></tr>

                    
                    </table>

                
                
                
                
                
                <h2>ADD DUTIES OF EMPLOYEES</h2>
                    <br />
                    <h3>ADD DUTIES OF EMPLOYEES FOR RIDES</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE RIDE:</b></td>
                            <td><asp:DropDownList ID="DropDownRide" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE EMPLOYEES:</b></td>
                            <td><asp:DropDownList ID="DropDownEmployee" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>DUTY:</b></td>
                            <td><asp:TextBox ID="TextDuty_Ride" placeholder="Enter Duty" runat="server" TextMode="SingleLine" 
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                            
                            </tr>
                        <tr>
                            <td><asp:Button ID="Button1" class="button" runat="server" Text="ADD" 
                                    onclick="BtnEmpRideDuty_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="LabelDuty_Ride" runat="server" ForeColor="Red" Text="Sucessfully Updated Duty...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelDutyInvalid_Ride" runat="server" ForeColor="Red" Text="ERROR...Cannot Update...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

                <br />
                <br />
                <br />
                    <h3>ADD DUTIES OF EMPLOYEES FOR SHOWS</h3>
                    <table>
                        <tr>
                            <td><b>CHOOSE SHOW:</b></td>
                            <td><asp:DropDownList ID="DropDownShow" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>CHOOSE EMPLOYEES:</b></td>
                            <td><asp:DropDownList ID="DropDownEmployee2" runat="server" Height="30px" Width="180px"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td><b>DUTY:</b></td>
                            <td><asp:TextBox ID="TextDuty_Show" placeholder="Enter Duty" runat="server" TextMode="SingleLine"
                                    Height="30px" Width="180px"></asp:TextBox></td>
                            <td></td>
                            <td><asp:Button ID="Button2" class="button" runat="server" Text="ADD" 
                                    onclick="BtnEmpShowDuty_Click" Height="40px" /></td>  
                        </tr>
                        <tr><td><asp:Label ID="LabelDuty_Show" runat="server" ForeColor="Red" Text="Sucessfully Updated Duty...!!" Visible="false"></asp:Label></td></tr> 
                        <tr><td><asp:Label ID="LabelDutyInvalid_Show" runat="server" ForeColor="Red" Text="ERROR...Cannot Update...!!" Visible="false"></asp:Label></td></tr> 
                    </table>

            </ div>
        </ div>
    <br />
    <br />
    <br />
</asp:Content>
