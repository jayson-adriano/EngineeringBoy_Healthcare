using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
namespace dllFiles
{
    public class Patient
    {

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LittleHospital_DB;Persist Security Info=True;User ID=Softeng;Password=softeng123");
        Helper hlp = new Helper();

        public string[] GetDetails(int actID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_PatientGetAccountDetails", con);
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;
            cmd.CommandType = CommandType.StoredProcedure;

            dt = hlp.resultHelper(cmd);
            string[] dets = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return dets;
        }

        public string updateProfile(string lastName, string firstName, string middleName, string userName, string password, string emailAddress, string address, int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientUpdateProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar, 50).Value = lastName;
                cmd.Parameters.Add("@First_Name", SqlDbType.VarChar, 50).Value = firstName;
                cmd.Parameters.Add("@Middle_Name", SqlDbType.VarChar, 50).Value = middleName;
                cmd.Parameters.Add("@Email_Address", SqlDbType.VarChar, 50).Value = emailAddress;
                cmd.Parameters.Add("@User_Name", SqlDbType.VarChar, 20).Value = userName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = password;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 250).Value = address;
                cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;

                return hlp.addHelper(cmd, con);
            
        }


        public DataTable DeactivateAccount(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientGetDeactivateAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }
        public DataTable ViewPrescriptions(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientGetMedPrescriptions", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }

        public DataTable ViewAbstract(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientGetMedAbstract", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }

        public DataTable ReactivateAccount(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientGetReactivateAccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }

        public string SubmitFeedback(int PatID, string message)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientAddFeedback", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Message", SqlDbType.VarChar, 250).Value = message;
            cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = PatID;

            return hlp.addHelper(cmd, con);
        }
        public DataTable ViewMessages(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientGetMessages", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }
        public DataTable ViewDoctors()
        {
            SqlCommand cmd = new SqlCommand("sp_ViewDoctors", con);
            return hlp.resultHelper(cmd);
        }
        public DataTable ViewDoctorMessages(int actID)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorGetMessages", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = actID;
            return hlp.resultHelper(cmd);
        }

        public string SendChat(int PatID, string message, string doctor)
        {
            SqlCommand cmd = new SqlCommand("sp_PatientSendChat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 150).Value = message;
            cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = PatID;
            cmd.Parameters.Add("@DoctorName", SqlDbType.VarChar, 30).Value = doctor;
            cmd.Parameters.Add("@Sent", SqlDbType.DateTime).Value = DateTime.Now;

            return hlp.addHelper(cmd, con);
        }
        public string SendChatDoctor(int DocID, string message, string patient)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorSendChat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Message", SqlDbType.NVarChar, 150).Value = message;
            cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = DocID;
            cmd.Parameters.Add("@PatientName", SqlDbType.VarChar, 30).Value = patient;
            cmd.Parameters.Add("@Sent", SqlDbType.DateTime).Value = DateTime.Now;

            return hlp.addHelper(cmd, con);
        }
    }
}
