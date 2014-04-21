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
    public partial class DeleteShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.FillDropDownList_Show();
                DropDownShow.DataTextField = ds.Tables[0].Columns["show_name"].ToString();
                DropDownShow.DataSource = ds.Tables[0];
                DropDownShow.DataBind();
            }
        }

        protected void BtnShowDelete_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            Show UserBO = new Show();
            UserBO.ShowName = DropDownShow.Text;
            DataSet ds = Userdal.Delete_Show(UserBO);
            if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {

                Label1.Visible = false;
                Label2.Visible = true;
            }
            else
            {
                Response.Redirect("DeleteShow.aspx", false);
                Label1.Visible = true;
                Label2.Visible = false;
            }

        }
    }
}