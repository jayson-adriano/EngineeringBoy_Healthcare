using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace dllFiles
{
    public class Account
    {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LittleHospital_DB;Persist Security Info=True;User ID=Softeng;Password=softeng123");
        SqlCommand cmd;
        Helper hlp = new Helper();

        public int logIn(string userName, string password)
        {
            SqlCommand cmd = new SqlCommand("sp_checkUsernameExist", con); //check if username does not exists
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = userName;
            SqlParameter sqlParam = new SqlParameter("@Result", DbType.Boolean);
            sqlParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlParam);

            hlp.checkingHelper(cmd, con);
            int result = int.Parse(cmd.Parameters["@Result"].Value.ToString());

            if (result == 1)
            {
                return -2; //username does no exist
            }
            else
            {
                cmd = new SqlCommand("sp_UnregisteredCheckUserAndPasswordMatch", con); //check if username and password matches
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = userName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = password;
                sqlParam = new SqlParameter("@Result", DbType.Boolean);
                sqlParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sqlParam);

                hlp.checkingHelper(cmd, con);
                result = int.Parse(cmd.Parameters["@Result"].Value.ToString());

                if (result == 1)
                {
                    return -3; //username and password does not match
                }
                else
                {
                    cmd = new SqlCommand("sp_PatientVerifyLogin", con); //assign accountID
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar, 20).Value = userName;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = password;

                    DataTable dt = hlp.resultHelper(cmd);

                    if (dt.Rows.Count > 0)
                    {
                        int userID = int.Parse(dt.Rows[0][0].ToString());
                        return userID;
                    }
                    else
                    {
                        return -1;  //invalid input: empty
                    }
                }
            }
        }

        public DataTable ViewPrescriptions(int actID)
        {
            SqlCommand cmd = new SqlCommand("PatientGetPrescriptions", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }

        public DataTable setCustomerID(int actID)
        {
            SqlCommand cmd = new SqlCommand("ClientGetCustomerID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int, 20).Value = actID;

            //DataTable dt = hlp.resultHelper(cmd);
            //int customerID = int.Parse(dt.Rows[0][0].ToString());

            return hlp.resultHelper(cmd);
        }

        public int getCustomerID(int actID)
        {
            int id = 0;
            DataTable dt = setCustomerID(actID);
            DataView dv = dt.DefaultView;

            foreach (DataRowView drv in dv)
            {
                id = int.Parse(drv.Row["Customer_ID"].ToString());
            }

            return id;
        }

        public string registerAccount(string lastName, string firstName, string middleName, string userName, string password, string emailAddress, string address, DateTime birthDate)
        {
            SqlCommand cmd = new SqlCommand("sp_checkUsernameExist", con); //check if username does not exists
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = userName;
            SqlParameter sqlParam = new SqlParameter("@Result", DbType.Boolean);
            sqlParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlParam);

            hlp.checkingHelper(cmd, con);
            int result = int.Parse(cmd.Parameters["@Result"].Value.ToString());

            if (result == 1)
            {
                //username does no exist, allow registration

                cmd = new SqlCommand("sp_AddAccountDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = lastName;
                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = firstName;
                cmd.Parameters.Add("@Middle_Name", SqlDbType.VarChar, 50).Value = middleName;
                cmd.Parameters.Add("@Email_Address", SqlDbType.VarChar, 50).Value = emailAddress;
                cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = birthDate.ToShortDateString();
                cmd.Parameters.Add("@User_Name", SqlDbType.VarChar, 20).Value = userName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = password;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 250).Value = address;

                return hlp.addHelper(cmd, con);
            }
            else
            {
                return "no";
            }
        }


        public string registerDoctorAccount(string lastName, string firstName, string middleName, string userName, string password, string emailAddress, string address, DateTime birthDate, string special)
        {
            SqlCommand cmd = new SqlCommand("sp_checkUsernameExist", con); //check if username does not exists
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = userName;
            SqlParameter sqlParam = new SqlParameter("@Result", DbType.Boolean);
            sqlParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlParam);

            hlp.checkingHelper(cmd, con);
            int result = int.Parse(cmd.Parameters["@Result"].Value.ToString());

            if (result == 1)
            {
                //username does no exist, allow registration

                cmd = new SqlCommand("sp_AddDoctorAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = lastName;
                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = firstName;
                cmd.Parameters.Add("@Middle_Name", SqlDbType.VarChar, 50).Value = middleName;
                cmd.Parameters.Add("@Email_Address", SqlDbType.VarChar, 50).Value = emailAddress;
                cmd.Parameters.Add("@Birthday", SqlDbType.Date).Value = birthDate.ToShortDateString();
                cmd.Parameters.Add("@User_Name", SqlDbType.VarChar, 20).Value = userName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = password;
                cmd.Parameters.Add("@Specialization", SqlDbType.VarChar, 50).Value = special;

                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 250).Value = address;

                return hlp.addHelper(cmd, con);
            }
            else
            {
                return "no";
            }
        }
        public int SetPatientID(int actID)
        {
            int id = 0;
            DataTable dt = GetPatientID(actID);
            DataView dv = dt.DefaultView;

            foreach (DataRowView drv in dv)
            {
                id = int.Parse(drv.Row["PatientID"].ToString());
            }

            return id;
        }

        public int SetDoctorID(int actID)
        {
            int id = 0;
            DataTable dt = GetDoctorID(actID);
            DataView dv = dt.DefaultView;

            foreach (DataRowView drv in dv)
            {
                id = int.Parse(drv.Row["DoctorID"].ToString());
            }

            return id;
        }
        public DataTable GetPatientID(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientGetID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;

            return hlp.resultHelper(cmd);
        }

        public DataTable GetDoctorID(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorGetID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;

            return hlp.resultHelper(cmd);
        }
        public string logOut()
        {

            return "melly";
        }

        public DataTable viewTestimonials()
        {
            SqlCommand cmd = new SqlCommand("ClientGetAcceptedTesti", con);
            cmd.CommandType = CommandType.StoredProcedure;
            return hlp.resultHelper(cmd);
        }

        public DataTable requestReactivation(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("ClientAddActivateRequest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = password;
            return hlp.resultHelper(cmd);
        }

        public string CheckIfDeactivated(int accID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientCheckIfDeactivated", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = accID;

            DataTable dt = hlp.resultHelper(cmd);
            return dt.Rows[0][0].ToString();
        }


        public string CheckDoctorExist(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_CheckIfDoctorExist", con); //check if username does not exists
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            SqlParameter sqlParam = new SqlParameter("@Result", DbType.Boolean);
            sqlParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sqlParam);

            hlp.checkingHelper(cmd, con);
            int result = int.Parse(cmd.Parameters["@Result"].Value.ToString());

            if (result == 1)
            {
                return "not a doctor"; //not a doctor
            }
            else
            {
                return "doctor";
            }
        }
    }
}
