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
    public partial class UpdateShow : System.Web.UI.Page
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

        public void BtnPrice_Click(object sender, EventArgs e)
        {
            Show UserBO = new Show();
            UserBO.ShowName = DropDownShow.Text;
            int price = int.Parse(TextPrice.Text);

            if (price > 0)
            {
                UserBO.Price = price;
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.PriceAlter_Show(UserBO);
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
            Show UserBO = new Show();
            UserBO.ShowName = DropDownShow.Text;
            int Person = int.Parse(TextPersons.Text);
            if (Person > 0)
            {
                UserBO.Persons = Person;
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.PersonAlter_Show(UserBO);
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

       
    }
}