<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Attractions.aspx.cs" Inherits="Project.Attractions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="attractionsdetails" style="width:960px; height:3150px; background-image:url(images/blue.jpg); background-repeat:no-repeat; background-attachment:fixed; background-size:100% 100%; font-size:larger; text-align:center;">
        <div id="internal" style="width:900px; margin:0 auto;">
            <b style=" font-size:xx-large; text-decoration:double;">UPCOMING ATTRACTIONS</b>

            <b style=" font-size:xx-large;">THEMED AREAS</b>
            
            <!--BOMER LAND-->
            <br /><br />
            <b style=" font-size:x-large;">BOOMER's LAND</b>
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
            

            <!--AQUA LAND-->
            <br />
            <b style=" font-size:x-large;">AQUA LAND</b>
            <table id="Table1" style=" text-align:justify;">
            <tr>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Acapulco Cliff Dive</h4>
                        <p>This is the water slide made for you. Acapulco Cliff Dive is a 65-foot tall high speed, high-thrill, free-fall slide. Must be at least 52" tall to ride and weight must not exceed 250 lbs.</p>
                    </div>
                </td>
                <td >
                    <img id="Img2" style=" width:200px; height:150px" src="images/CliffDive.jpg" alt="PICTURE"/> 
                </td>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Half Pipe</h4><!--aqualine ride 2-->
                    <p>Elitch Gardens Half Pipe is most thrilling snowboard ride around. Guests get to thrash, shred and carve their way to the rim of the Half Pipe while spinning around and around. It’s truly epic, dudes and dudettes. </p>
                    </div>
                </td>
                <td>
                    <img id="Img3" style=" width:200px; height:150px" src="images/HalfPipe.jpg" alt="PICTURE" /> 
                </td>
            </tr>
            </table>
            

            <!--JOY LAND-->
            <b style=" font-size:x-large;">JOY LAND</b>
            <table id="Table3" style=" text-align:justify;">
            <tr>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Turn of the Century</h4><!--ride 1 name-->
                        <p>The Turn of the Century gives Elitch Gardens guests a chance to swing into a piece of history.</p>
                    </div>
                </td>
                <td >
                    <img id="Img6" style=" width:200px; height:150px" src="images/Turn-of-the-Century.jpg" alt="PICTURE"/> 
                </td>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Twister II</h4><!--ride 2 name-->
                    <p>The world-class wooden roller coaster is a 10-story superstructure featuring a 90-foot drop and a pitch black tunnel.The Twister II is the longest coaster in the park!</p>
                    </div>
                </td>
                <td><!--just change the name of image -->
                    <img id="Img7" style=" width:200px; height:150px" src="images/TwisterII.jpg" alt="PICTURE" /> 
                </td>
            </tr>
            </table>


            <!--DOREMON LAND-->
            <b style=" font-size:x-large;">DOREMON LAND</b>
            <table id="Table2" style=" text-align:justify;">
            <tr>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>XLR8R</h4><!--ride 1 name-->
                        <p>From Broncos players to celebrities and locals alike, many have taken the flight of their life on the XLR8R. Guests are pulled up 150 feet in the air and dropped in a full free-fall experience which mixes together the best of bungee jumping, hang-gliding and skydiving.</p>
                    </div>
                </td>
                <td >
                    <img id="Img4" style=" width:200px; height:150px" src="images/XLR8R2.jpg" alt="Picture"/> 
                </td>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Ding Dong Dock</h4><!--ride 2 name-->
                    <p>Kids will love being the captain of their boat on Ding Dong Dock! The boats travel in a circular course.</p>
                    </div>
                </td>
                <td>
                    <img id="Img5" style=" width:200px; height:150px" src="images/DingDongDock.png" alt="PICTURE" /> 
                </td>
            </tr>
            </table>


            <!--SHOWS-->
            <b style=" font-size:x-large;">SHOWS</b>
            <table id="Table7" style=" text-align:justify;">
            <tr>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Indiana Jones Adventure</h4><!--SHOW 1 name-->
                        <p>An E-Ticket tour de force, Indiana Jones Adventure immerses guests into the world of the popular movie series through the use of Disney's innovative Enhanced Motion Vehicles, highly elaborate sets, and a stunning array of effects. It is one of Imagineering's crowning achievements.</p>
                    </div>
                </td>
                <td >
                    <img id="Img9" style=" width:200px; height:150px" src="images/Indiana-Jones-Disneyland.jpg" alt="Picture"/> 
                </td>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Revenge of the Mummy</h4><!--show 2 name-->
                    <p>Universal incorporates so many innovations into its utterly unique dark ride/coaster, it has coined a new label for Revenge of the Mummy: psychological thrill ride. With its inky darkness, creepy scarabs, and other freak-out inducers, the ride plays a winning mind-games hand.</p>
                    </div>
                </td>
                <td>
                    <img id="Img11" style=" width:200px; height:150px" src="images/mummy.jpg" alt="PICTURE" /> 
                </td>
            </tr>

            <tr>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Pirates of the Caribbean</h4><!--show 3 name-->
                        <p>Dead men may tell no tales, but Disney's Pirates of the Caribbean have entertained millions with their salty tales. A landmark achievement in theme park storytelling when it debuted in 1967. </p>
                    </div>
                </td>
                <td >
                    <img id="Img13" style=" width:200px; height:150px" src="images/POC.jpg" alt="Picture"/> 
                </td>
                <td>
                    <div style="width:250px; height:250px;">
                        <h4>Amazing Adventures of Spider-Man</h4><!--show 4 name-->
                    <p>This incredible--OK, Amazing--attraction combines a groundbreaking roving motion base simulator technology with a 3-D film experience to totally immerse riders in the world of Spidey and his archenemies.</p>
                    </div>
                </td>
                <td>
                    <img id="Img14" style=" width:200px; height:150px" src="images/SpideMan.jpg"  alt="PICTURE" /> 
                </td>
            </tr>
            </table>

            <b style=" font-size:xx-large;">UPCOMING ATTRACTIONS</b>
            <br />   
            <!--CINEMA-->
            <b style=" font-size:x-large;">CINEMA</b>
            <table id="Table4" style=" text-align:justify;">
            <tr>
                <td>
                    <div style="width:500px; height:350px;">
                        <h4>SILENT RUNNING</h4><!--CINEMA name-->
                        <p>The development of video amusement technology is also rising. Viewers can experience shocks, falls, rises and other effects in some 4D cinemas, while in the 5D cinema, they are able to experience different kinds of fresh features, such as lightning, snow, water spraying, wind blowing, bubble, smog, leg sweeping and many other funny effects, which are not included in our 4D cinema. </p>
                    </div>
                </td>
                <td >
                    <img id="Img8" style=" width:400px; height:250px" src="images/cinema.jpg" alt="Picture"/> 
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
                        <p>You're never more than a few steps away from great food at theme parks. You’ll find everything from convenient street carts offering quick snacks to award-winning, full-service themed dining. Enjoy a delicious dinner at Ornaldo's Seafood Grille. Choose from an array of entrees including fresh seafood, pasta, sandwiches and more.  </p>
                    </div>
                </td>
                <td >
                    <img id="Img10" style=" width:400px; height:250px" src="images/Resturtant.jpg" alt="Picture"/> 
                </td>
            </tr>
            </table>


            <!--HOTEL-->
            <b style=" font-size:x-large;">HOTEL</b>
            <table id="Table6" style=" text-align:justify;">
            <tr>
                <td>
                    <div style="width:500px; height:350px;">
                        <h4>Genting Highlands</h4><!--ride 1 name-->
                        <p>Perched on a misty mountain top, Theme Park Hotel Genting Highlands greets holidaymakers with a fantasy-inspired facade and comfortable accommodations in Genting Highlands. While in the area, visitors can check out Chin Swee Cave Temple, watch performers at Arena of Stars or try indoor sky diving through wind tunnels at Sky Venture. </p>
                    </div>
                </td>
                <td >
                    <img id="Img12" style=" width:400px; height:250px" src="images/themeparkhotel.jpg" alt="Picture"/> 
                </td>
            </tr>
            </table>


        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
