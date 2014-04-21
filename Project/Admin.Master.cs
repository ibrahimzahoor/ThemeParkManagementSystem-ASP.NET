using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Name"] != null)
            {
                Labellogin.Text = "     " + Request.QueryString["Name"] + "  has LOGGED IN SUCESSFULLY....!!                                ";
                Labellogin.Visible = true;
                

            }
        }

        public System.Drawing.Color black { get; set; }
    }
}