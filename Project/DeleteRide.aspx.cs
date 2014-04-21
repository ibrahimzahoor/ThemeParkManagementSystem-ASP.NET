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
    public partial class DeleteRide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.FillDropDownList();
                DropDownRide.DataTextField = ds.Tables[0].Columns["ride_name"].ToString();
                DropDownRide.DataSource = ds.Tables[0];
                DropDownRide.DataBind();
            }
        }

        protected void BtnRideDelete_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            Ride UserBO = new Ride();
            UserBO.RideName = DropDownRide.Text;
            DataSet ds = Userdal.Delete_Ride(UserBO);
            if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {

                Label1.Visible = false;
                Label2.Visible = true;
            }
            else
            {
                Response.Redirect("DeleteRide.aspx", false);
                Label1.Visible = true;
                Label2.Visible = false;
            }

        }
    }
}