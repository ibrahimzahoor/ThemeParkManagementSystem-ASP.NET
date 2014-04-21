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
    public partial class RideGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            GridView gridview = new GridView();
            PlaceHolderRide.Controls.Add(gridview);
            DataSet ds = Userdal.Grid_Ride();
            gridview.DataSource = ds;
            gridview.DataBind();
            gridview.CellPadding=10;

            UserDAL Userdal1 = new UserDAL();
            GridView gridview1 = new GridView();
            PlaceHolderRide1.Controls.Add(gridview);
            DataSet ds1 = Userdal.Grid_Ride();
            gridview1.DataSource = ds1;
            gridview1.DataBind();
            gridview1.CellPadding = 10;
            gridview1.Caption = "TICKET PRICES";
        }
    }
}