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
    public partial class UpdateRide : System.Web.UI.Page
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

        public void BtnPrice_Click(object sender, EventArgs e)
        {
            if (TextPrice.Text.Trim().Length == 0)
            {
                LabelPrice.Visible = true;
                return;
            }
            else
                LabelPrice.Visible = false;

            Ride UserBO = new Ride();
            UserBO.RideName = DropDownRide.Text;
            if (!(TextPrice.Text.Trim().Length == 0))
            {
                UserBO.Price = int.Parse(TextPrice.Text);
            }

            if (UserBO.Price >= 0 )
            {
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.PriceAlter_Ride(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {
                    LabelPrice.Visible = true;
                    LabelPriceInvalid.Visible = false;
                }
                else
                {
                    LabelPrice.Visible = false;
                    LabelPriceInvalid.Visible = true;
                }
            }
            else
            {
                LabelPrice.Visible = false;
                LabelPriceInvalid.Visible = true;
            }
        }

        public void BtnPersons_Click(object sender, EventArgs e)
        {
            Ride UserBO = new Ride();
            UserBO.RideName = DropDownRide.Text;
            int Person = int.Parse(TextPersons.Text);
            if (Person > 0)
            {
                UserBO.Persons = Person;
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.PersonAlter_Ride(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {
                    LabelPersons.Visible = true;
                    LabelPersonsInvalid.Visible = false;
                }
                else
                {
                    LabelPersons.Visible = false;
                    LabelPersonsInvalid.Visible = true;
                }
            }
            else
            {
                LabelPersons.Visible = false;
                LabelPersonsInvalid.Visible = true;
            }
        }

        public void BtnAge_Click(object sender, EventArgs e)
        {
            Ride UserBO = new Ride();
            UserBO.RideName = DropDownRide.Text;
            int age = int.Parse(TextAgeLimit.Text);

            if (age > 0)
            {
                UserBO.Age = age;
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.AgeAlter_Ride(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {
                    LabelAge.Visible = true;
                    LabelAgeInvalid.Visible = false;
                }
                else
                {
                    LabelAge.Visible = false;
                    LabelAgeInvalid.Visible = true;
                }
            }
            else
            {
                LabelAge.Visible = false;
                LabelAgeInvalid.Visible = true;
            }
          }



        

        
    }
}