using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Project.BO;

namespace Project.DAL
{

    public class UserDAL
    {
        private static readonly string connString = System.Configuration.ConfigurationManager.ConnectionStrings["project"].ConnectionString;

        public DataSet FillDropDownList()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ride_name from RIDES", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet FillDropDownList_Show()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select show_name from SHOWS", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet FillDropDownList_Area()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select area_name from THEME_AREA", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet AuthenticateUser(UserBO user)
        {

            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("LoginAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar,25).Value = user.UserName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar,25).Value = user.Password;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet PriceAlter_Ride(Ride user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("PriceAlter", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = user.Price;
                cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar, 25).Value = user.RideName;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet AgeAlter_Ride(Ride user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("AgeAlter", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = user.Age;
                cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar, 25).Value = user.RideName;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet PersonAlter_Ride(Ride user)
          {
              DataSet ds = new DataSet();
              SqlConnection con = new SqlConnection(connString);
              con.Open();
              //Here we declare the parameter which we have to use in our application
              SqlCommand cmd;
              try
              {
                  cmd = new SqlCommand("PersonAlter", con);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.Add("@Person", SqlDbType.Int).Value = user.Persons;
                  cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar, 25).Value = user.RideName;
                  using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                  {
                      // Fill the DataSet using default values for DataTable names, etc
                      da.Fill(ds);
                  }
              }
              catch (SqlException ex)
              {
                  Console.WriteLine("SQL Error" + ex.Message.ToString());
              }
              finally
              {
                  con.Close();
              }
              return ds;
          }

        public DataSet PriceAlter_Show(Show user)
          {
              DataSet ds = new DataSet();
              SqlConnection con = new SqlConnection(connString);
              con.Open();
              //Here we declare the parameter which we have to use in our application
              SqlCommand cmd;
              try
              {
                  cmd = new SqlCommand("PriceAlterShow", con);
                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.Add("@Price", SqlDbType.Int).Value = user.Price;
                  cmd.Parameters.Add("@Show_Name", SqlDbType.VarChar, 25).Value = user.ShowName;

                  using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                  {
                      // Fill the DataSet using default values for DataTable names, etc
                      da.Fill(ds);
                  }
              }
              catch (SqlException ex)
              {
                  Console.WriteLine("SQL Error" + ex.Message.ToString());
              }
              finally
              {
                  con.Close();
              }
              return ds;
          }

        public DataSet PersonAlter_Show(Show user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("PersonAlterShow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Person", SqlDbType.Int).Value = user.Persons;
                cmd.Parameters.Add("@Show_Name", SqlDbType.VarChar, 25).Value = user.ShowName;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet EmpRideDuty(EmployeeRideDuty user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("EmpRideDuty", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar, 25).Value = user.RideName;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmpName;
                cmd.Parameters.Add("@Duty", SqlDbType.VarChar, 25).Value = user.Duty;
                cmd.Parameters.Add("@Ride_ID", SqlDbType.VarChar, 25).Value = user.RideID;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.VarChar, 25).Value = user.EmpID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet EmpShowDuty(EmployeeShowDuty user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("EmpShowDuty", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Show_Name", SqlDbType.VarChar, 25).Value = user.ShowName;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmpName;
                cmd.Parameters.Add("@Duty", SqlDbType.VarChar, 25).Value = user.Duty;
                cmd.Parameters.Add("@Show_ID", SqlDbType.VarChar, 25).Value = user.ShowID;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.VarChar, 25).Value = user.EmpID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet EmpRideDuty_Update(EmployeeRideDuty user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("EmpRideDuty_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar, 25).Value = user.RideName;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmpName;
                cmd.Parameters.Add("@Duty", SqlDbType.VarChar, 25).Value = user.Duty;
                cmd.Parameters.Add("@Ride_ID", SqlDbType.VarChar, 25).Value = user.RideID;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.VarChar, 25).Value = user.EmpID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet EmpShowDuty_Update(EmployeeShowDuty user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("EmpShowDuty_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Show_Name", SqlDbType.VarChar, 25).Value = user.ShowName;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmpName;
                cmd.Parameters.Add("@Duty", SqlDbType.VarChar, 25).Value = user.Duty;
                cmd.Parameters.Add("@Show_ID", SqlDbType.VarChar, 25).Value = user.ShowID;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.VarChar, 25).Value = user.EmpID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet FillDropDownList_Employee()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select employee_name from EMPLOYEE", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet EmpRideDelete(EmployeeRideDelete user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("EmpRideDutyDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmpName;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.VarChar, 25).Value = user.EmpID;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet EmpShowDelete(EmployeeRideDelete user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("EmpsHOWDutyDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmpName;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.VarChar, 25).Value = user.EmpID;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet Add_Employee(Employee user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Add_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar).Value = user.EmployeeName;
                cmd.Parameters.Add("@Emp_CNIC", SqlDbType.VarChar).Value = user.EmployeeCNIC;
                cmd.Parameters.Add("@Emp_Address", SqlDbType.VarChar).Value = user.EmployeeAdress;
                cmd.Parameters.Add("@Emp_Sex", SqlDbType.VarChar).Value = user.EmployeeSex;
                cmd.Parameters.Add("@Emp_Salary", SqlDbType.Int).Value = user.Salary;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet Add_Ride(Ride user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Add_Ride", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar).Value = user.RideName;
                cmd.Parameters.Add("@Ride_Price", SqlDbType.Int).Value = user.Price;
                cmd.Parameters.Add("@Ride_Persons", SqlDbType.Int).Value = user.Persons;
                cmd.Parameters.Add("@Ride_Age", SqlDbType.Int).Value = user.Age;
                cmd.Parameters.Add("@Area_Name", SqlDbType.VarChar).Value = user.AreaName;
                cmd.Parameters.Add("@Emp_name", SqlDbType.VarChar).Value = user.EmployeeName;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet Add_Show(Show user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Add_Show", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Show_Name", SqlDbType.VarChar).Value = user.ShowName;
                cmd.Parameters.Add("@Show_Price", SqlDbType.Int).Value = user.Price;
                cmd.Parameters.Add("@Show_Persons", SqlDbType.Int).Value = user.Persons;
                cmd.Parameters.Add("@Area_Name", SqlDbType.VarChar).Value = user.AreaName;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar).Value = user.EmployeeName;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet Delete_Employee(Employee user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Delete_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar, 25).Value = user.EmployeeName;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet Grid_Employee()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select employee_name as NAME,employee_CNIC as CNIC,employee_salary as SALARY,employee_sex as SEX,employee_address as ADDRESS from EMPLOYEE", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet Grid_Ride()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select R.ride_name as NAME,R.ride_ticketprice as PRICE,R.ride_noofperson as PERSONALLOWED,R.ride_age_limit as AGELIMIT,E.employee_name as MANAGERNAME,T.area_name as AREANAME  from RIDES as R,EMPLOYEE as E,THEME_AREA AS T where E.employee_ID=R.ride_managerID and T.area_ID=R.area_ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet Grid_Ride1()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select R.ride_name as NAME,R.ride_ticketprice as PRICE from RIDES as R", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet Grid_Show()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select S.show_name as NAME,S.show_ticketprice as PRICE,S.show_noofperson as PERSONALLOWED,E.employee_name as MANAGERNAME,T.area_name as AREANAME   from SHOWS as S,EMPLOYEE as E,THEME_AREA AS T where E.employee_ID=S.show_managerID and T.area_ID=S.area_ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet Grid_RideTicket()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select R.ride_name as RIDE__NAME, R.ride_ticketprice as TICKET__PRICE from RIDES as R", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet Grid_ShowTicket()
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select S.show_name as SHOW__NAME, S.show_ticketprice as TICKET__PRICE from SHOWS as S", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet Delete_Ride(Ride user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Delete_Ride", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ride_Name", SqlDbType.VarChar, 25).Value = user.RideName;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }

        public DataSet Delete_Show(Show user)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            //Here we declare the parameter which we have to use in our application
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Delete_Show", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Show_Name", SqlDbType.VarChar, 25).Value = user.ShowName;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }


    
    }
    

}



      
