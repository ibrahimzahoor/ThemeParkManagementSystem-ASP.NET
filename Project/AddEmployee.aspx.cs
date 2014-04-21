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
    public partial class AddEmployee1 : System.Web.UI.Page
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

                
                UserDAL Userdal1 = new UserDAL();
                DataSet ds1 = Userdal.FillDropDownList_Employee();
                DropDownEmployee2.DataTextField = ds1.Tables[0].Columns["employee_name"].ToString();
                DropDownEmployee2.DataSource = ds1.Tables[0];
                DropDownEmployee2.DataBind();
                DropDownEmployee.DataTextField = ds1.Tables[0].Columns["employee_name"].ToString();
                DropDownEmployee.DataSource = ds1.Tables[0];
                DropDownEmployee.DataBind();


                UserDAL Userdal2 = new UserDAL();
                DataSet ds2 = Userdal2.FillDropDownList_Show();
                DropDownShow.DataTextField = ds2.Tables[0].Columns["show_name"].ToString();
                DropDownShow.DataSource = ds2.Tables[0];
                DropDownShow.DataBind();
            }
        }

        protected void BtnEmpRideDuty_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            EmployeeRideDuty UserBO = new EmployeeRideDuty();
            UserBO.RideName = DropDownRide.Text;
            UserBO.EmpName = DropDownEmployee.Text;
            UserBO.Duty = TextDuty_Ride.Text;

            DataSet ds = Userdal.EmpRideDuty(UserBO);
            if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {
                LabelDuty_Ride.Visible = true;
                LabelDutyInvalid_Ride.Visible = false;
            }
            else
            {
                LabelDuty_Ride.Visible = false;
                LabelDutyInvalid_Ride.Visible = true;
            }

        }

        protected void BtnEmpShowDuty_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            EmployeeShowDuty UserBO = new EmployeeShowDuty();
            UserBO.ShowName = DropDownShow.Text;
            UserBO.EmpName = DropDownEmployee2.Text;
            UserBO.Duty = TextDuty_Show.Text;

            DataSet ds = Userdal.EmpShowDuty(UserBO);
            if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {
                LabelDuty_Show.Visible = true;
                LabelDutyInvalid_Show.Visible = false;
            }
            else
            {
                LabelDuty_Show.Visible = false;
                LabelDutyInvalid_Show.Visible = true;
            }

        }

        protected void BtnEmpAdd_Click(object sender, EventArgs e)
        {
            if (name.Text.Trim().Length == 0 || cnic.Text.Trim().Length == 0 || sex.Text.Trim().Length == 0)
            {
                Label.Visible = true;
                return;
            }
            else
                Label.Visible = false;

            UserDAL Userdal = new UserDAL();
            Employee UserBO = new Employee();
            UserBO.EmployeeName = name.Text;
            UserBO.EmployeeCNIC = cnic.Text;
            UserBO.EmployeeSex = sex.Text;
            UserBO.EmployeeAdress = address.Text;
            
            if (Salary.Text.Trim().Length == 0)
                UserBO.Salary = null;
            else
                UserBO.Salary = int.Parse(Salary.Text);

            if (UserBO.Salary>=0 || UserBO.Salary==null) 
            {
                DataSet ds = Userdal.Add_Employee(UserBO);
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