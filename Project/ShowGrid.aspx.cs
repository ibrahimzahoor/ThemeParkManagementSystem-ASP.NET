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
    public partial class ShowGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            GridView gridview = new GridView();
            PlaceHolderShow.Controls.Add(gridview);
            DataSet ds = Userdal.Grid_Show();
            gridview.DataSource = ds;
            gridview.DataBind();
            gridview.CellPadding = 10;
        }
    }
}