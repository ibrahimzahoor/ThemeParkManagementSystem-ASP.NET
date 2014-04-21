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
    public partial class DeleteEmployee : System.Web.UI.Page
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
               DataSet ds1 = Userdal1.FillDropDownList_Employee();
               DropDownEmployee.DataTextField = ds1.Tables[0].Columns["employee_name"].ToString();
               DropDownEmployee.DataSource = ds1.Tables[0];
               DropDownEmployee.DataBind();

               UserDAL Userdal2 = new UserDAL();
               DataSet ds2 = Userdal2.FillDropDownList_Show();
               DropDownShow.DataTextField = ds2.Tables[0].Columns["show_name"].ToString();
               DropDownShow.DataSource = ds2.Tables[0];
               DropDownShow.DataBind();

               UserDAL Userdal3 = new UserDAL();
               DataSet ds3 = Userdal3.FillDropDownList_Employee();
               DropDownEmployeeNEW.DataTextField = ds3.Tables[0].Columns["employee_name"].ToString();
               DropDownEmployeeNEW.DataSource = ds3.Tables[0];
               DropDownEmployeeNEW.DataBind();



               UserDAL Userdal4 = new UserDAL();
               DataSet ds4 = Userdal4.FillDropDownList_Employee();
               DropDownList3.DataTextField = ds4.Tables[0].Columns["employee_name"].ToString();
               DropDownList3.DataSource = ds4.Tables[0];
               DropDownList3.DataBind();
            }
        }


        protected void BtnEmpRideDelete_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            EmployeeRideDelete UserBO = new EmployeeRideDelete();
                UserBO.EmpName = DropDownEmployee.Text;
                DataSet ds = Userdal.EmpRideDelete(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {
                    LabelDutyInvalid_Ride.Visible = true;
                    LabelDuty_Ride.Visible = false;
                }
                else
                {
                    Response.Redirect("DeleteEmployee.aspx", false);
                    LabelDutyInvalid_Ride.Visible = false;
                    LabelDuty_Ride.Visible = true;
                }
        
        }

        protected void BtnEmpShowDelete_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            EmployeeRideDelete UserBO = new EmployeeRideDelete();
                UserBO.EmpName = DropDownEmployeeNEW.Text;
                DataSet ds = Userdal.EmpShowDelete(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {
                    LabelDutyInvalid_Show.Visible = true;
                    LabelDuty_Show.Visible = false;
                }
                else
                {
                    Response.Redirect("DeleteEmployee.aspx", false);
                    LabelDutyInvalid_Show.Visible = false;
                    LabelDuty_Show.Visible = true;
                }
        }   



        protected void BtnEmpDelete_Click(object sender, EventArgs e)
        {
            UserDAL Userdal = new UserDAL();
            Employee UserBO = new Employee();
                UserBO.EmployeeName = DropDownList3.Text;
                DataSet ds = Userdal.Delete_Employee(UserBO);
                if (ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
                {

                    Label1.Visible = false;
                    Label2.Visible = true;
                 }
                else
                    {
                        Response.Redirect("DeleteEmployee.aspx", false);
                    Label1.Visible = true;
                    Label2.Visible = false;
                    }
        
        }
   
    
    
    
    
    }
}