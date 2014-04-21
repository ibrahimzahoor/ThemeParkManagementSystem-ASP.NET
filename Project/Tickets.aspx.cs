using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BO;
using Project.DAL;
using System.Data;

namespace Project
{
    public partial class Tickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            GridView gridview = new GridView();
            PlaceHolderRideTicket.Controls.Add(gridview);
            DataSet ds = Userdal.Grid_RideTicket();
            gridview.DataSource = ds;
            gridview.DataBind();
            gridview.CellPadding = 20;
            gridview.BorderWidth = 10;
            
            UserDAL Userdal1 = new UserDAL();
            GridView gridview1 = new GridView();
            PlaceHolderShowTicket.Controls.Add(gridview1);
            DataSet ds1 = Userdal1.Grid_ShowTicket();
            gridview1.DataSource = ds1;
            gridview1.DataBind();
            gridview1.CellPadding = 20;
            gridview1.BorderWidth = 10;
  




        }
    }
}