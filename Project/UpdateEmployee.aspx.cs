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
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserDAL Userdal1 = new UserDAL();
                DataSet ds1 = Userdal1.FillDropDownList();
                DropDown_RideNEW.DataTextField = ds1.Tables[0].Columns["ride_name"].ToString();
                DropDown_RideNEW.DataSource = ds1.Tables[0];
                DropDown_RideNEW.DataBind();


                UserDAL Userdal2 = new UserDAL();
                DataSet ds2 = Userdal2.FillDropDownList_Employee();
                DropDownEmployee_RideNEW.DataTextField = ds2.Tables[0].Columns["employee_name"].ToString();
                DropDownEmployee_RideNEW.DataSource = ds2.Tables[0];
                DropDownEmployee_RideNEW.DataBind();


                UserDAL Userdal3 = new UserDAL();
                DataSet ds3 = Userdal3.FillDropDownList_Employee();
                DropDownEmployee_ShowNEW.DataTextField = ds3.Tables[0].Columns["employee_name"].ToString();
                DropDownEmployee_ShowNEW.DataSource = ds3.Tables[0];
                DropDownEmployee_ShowNEW.DataBind();


                UserDAL Userdal4 = new UserDAL();
                DataSet ds4 = Userdal4.FillDropDownList_Show();
                DropDown_ShowNEW.DataTextField = ds4.Tables[0].Columns["show_name"].ToString();
                DropDown_ShowNEW.DataSource = ds4.Tables[0];
                DropDown_ShowNEW.DataBind();
            } 
        }

        protected void BtnEmpRideDuty_Update_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            EmployeeRideDuty UserBO = new EmployeeRideDuty();
            UserBO.RideName = DropDown_RideNEW.Text;
            UserBO.EmpName = DropDownEmployee_RideNEW.Text;
            UserBO.Duty = TextDuty_RideNEW.Text;

            DataSet ds = Userdal.EmpRideDuty(UserBO);
            if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {
                LabelDuty_RideNEW.Visible = true;
                LabelDutyInvalid_RideNEW.Visible = false;
            }
            else
            {
                LabelDuty_RideNEW.Visible = false;
                LabelDutyInvalid_RideNEW.Visible = true;
            }

        }

        protected void BtnEmpShowDuty_Update_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            EmployeeShowDuty UserBO = new EmployeeShowDuty();
            UserBO.ShowName = DropDown_ShowNEW.Text;
            UserBO.EmpName = DropDownEmployee_ShowNEW.Text;
            UserBO.Duty = TextDuty_ShowNEW.Text;

            DataSet ds = Userdal.EmpShowDuty(UserBO);
            if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {
                LabelDuty_ShowNEW.Visible = true;
                LabelDutyInvalid_ShowNEW.Visible = false;
            }
            else
            {
                LabelDuty_ShowNEW.Visible = false;
                LabelDutyInvalid_ShowNEW.Visible = true;
            }

        }

    }
}