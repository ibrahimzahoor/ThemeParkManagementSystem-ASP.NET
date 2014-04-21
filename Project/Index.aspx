<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Project.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div id="sliderFrame">
        <div id="slider">
            <img src="Images/1.jpg" alt=""/>
            <img src="Images/2.jpg" alt=""/>
            <img src="Images/3.jpg" alt=""/>
            <img src="Images/4.jpg" alt=""/>
            <img src="Images/5.jpg" alt=""/>
            <img src="Images/6.png" alt=""/>
        </div>
            </div>
 
    <div id="line" style="height:15px; margin:0 auto; background-color:Black;"></div>
    <div id="attractionsdetails" style="height:auto; background-image:url(Images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger; text-align:center;">
            <div id="internal" style="width:900px; margin:0 auto;">
                
                <br /><br />
                <b style=" font-size:xx-large; text-decoration:double;">UPCOMING ATTRACTIONS</b>
                <br />
                <!--CINEMA-->
                <b style=" font-size:x-large;">CINEMA</b>
                <table id="Table4" style=" text-align:justify;">
                <tr>
                    <td>
                        <div style="width:500px; height:325px;">
                            <h4>SILENT RUNNING</h4><!--CINEMA name-->
                            <p>The development of video amusement technology is also rising. Viewers can experience shocks, falls, rises and other effects in some 4D cinemas, while in the 5D cinema, they are able to experience different kinds of fresh features, such as lightning, snow, water spraying, wind blowing, bubble, smog, leg sweeping and many other funny effects, which are not included in our 4D cinema. </p>
                        </div>
                    </td>
                    <td >
                        <img id="Img8" style=" width:400px; height:250px;border:10px" src="images/cinema.jpg" alt="Picture"/> 
                    </td>
                </tr>
                </table>

                <!--RESTURANT-->
                <b style=" font-size:x-large;">RESTURANT</b>
                <table id="Table5" style=" text-align:justify;">
                <tr>
                    <td>
                        <div style="width:500px; height:350px;">
                            <h4>Orlando Resturant</h4><!--ride 1 name-->
                            <p>You're never more than a few steps away from great food at theme parks. You’ll find everything from convenient street carts offering quick snacks to award-winning, full-service themed dining. Enjoy a delicious dinner at Ornaldo's Seafood Grille. Choose from an array of entrees including fresh seafood, pasta, sandwiches and more.</p>
                        </div>
                    </td>
                    <td >
                        <img id="Img10" style=" width:400px; height:250px" src="images/Resturtant.jpg" alt="Picture"/> 
                    </td>
                </tr>
                </table>
                
                <br /><br />
                <b style=" font-size:xx-large;">UPCOMING RIDES</b>
            
                <!--BOMER LAND-->
                <br /><br />
                <table id="themed_area1" style=" text-align:justify;">
                <tr>
                    <td>
                        <div style="width:250px; height:250px;">
                            <h4>Mind Eraser</h4>
                            <p> The Mind Eraser is a monster coaster that suspends riders and blasts them through rollovers, dives and double corkscrew spins at speeds greater than 50 mph.</p>
                        </div>
                    </td>
                    <td >
                        <img id="pic1" style=" width:200px; height:150px" src="images/MindEraser.jpg" alt="ccdc"/> 
                    </td>
                    <td>
                        <div style="width:250px; height:250px;">
                            <h4>Montyzoomers Thunderdome</h4>
                        <p>At the centre of Wild Thing! is the extraordinary Montyzomers’ ball firing Thunderdome. Hidden amongst the bamboo platforms you can fire balls at each other with special cannons. But beware – for the mighty Montyzoomer has the ability to fire back!</p>
                        </div>
                    </td>
                    <td>
                        <img id="Img1" style=" width:200px; height:150px" src="images/monto.jpg" alt="ccdc" /> 
                    </td>
                </tr>
                </table>
            
                

            </ div>
    </ div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
