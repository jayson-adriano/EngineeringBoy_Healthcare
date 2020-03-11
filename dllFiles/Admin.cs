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
    public class Admin
    {

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LittleHospital_DB;Persist Security Info=True;User ID=Softeng;Password=softeng123");
        SqlCommand cmd;
        Helper hlp = new Helper();


        public string[] GetAbout()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_AdminGetAbout", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = hlp.resultHelper(cmd);
            string[] dets = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return dets;
        }

        public string[] GetContact()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_AdminContact", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = hlp.resultHelper(cmd);
            string[] dets = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            return dets;
        }


        public string SubmitEditInformation(string about, string contact)
        {
            SqlCommand cmd = new SqlCommand("sp_AdminEditInformation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@About", SqlDbType.VarChar, 250).Value = about;
            cmd.Parameters.Add("@Contact", SqlDbType.VarChar, 250).Value = contact;

            return hlp.addHelper(cmd, con);
        }
    }
}
