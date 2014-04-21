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
    public partial class AddRIDE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDAL Userdal = new UserDAL();
                DataSet ds = Userdal.FillDropDownList_Area();
                DropDownArea.DataTextField = ds.Tables[0].Columns["area_name"].ToString();
                DropDownArea.DataSource = ds.Tables[0];
                DropDownArea.DataBind();


                UserDAL Userdal1 = new UserDAL();
                DataSet ds1 = Userdal.FillDropDownList_Employee();
                DropDownManager.DataTextField = ds1.Tables[0].Columns["employee_name"].ToString();
                DropDownManager.DataSource = ds1.Tables[0];
                DropDownManager.DataBind();
            }
        }


        protected void BtnRideAdd_Click(object sender, EventArgs e)
        {
            if (name.Text.Trim().Length == 0)
            {
                Label.Visible = true;
                return;
            }
            else
                Label.Visible = false;

            UserDAL Userdal = new UserDAL();
            Ride UserBO = new Ride();

            if (price.Text.Trim().Length == 0)
            {
                UserBO.Price = null;
            }
            else
            {
                UserBO.Price = int.Parse(price.Text);
            }
            if (persons.Text.Trim().Length == 0)
            {
                UserBO.Persons = null ;
            }
            else
            {
                UserBO.Persons = int.Parse(persons.Text);
            }
            if (age.Text.Trim().Length == 0)
            {
                UserBO.Age = null;
            }
            else
            {
                UserBO.Age = int.Parse(age.Text);
            }
            UserBO.RideName = name.Text;
            UserBO.AreaName = DropDownArea.Text;
            UserBO.EmployeeName = DropDownManager.Text;

            if ((UserBO.Price >= 0 && UserBO.Persons >= 0 && UserBO.Age >=0) || (UserBO.Price == null || UserBO.Persons == null || UserBO.Age ==null ))
            {
                
                DataSet ds = Userdal.Add_Ride(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {
                    Label1.Visible = true;
                    Label2.Visible = false;
                }
                else
                {
                    Label1.Visible = false;
                    Label2.Visible = true;
                }
            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = true;
            }
        }
    }
}