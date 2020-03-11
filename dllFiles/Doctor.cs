using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dllFiles
{
    public class Doctor
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LittleHospital_DB;Persist Security Info=True;User ID=Softeng;Password=softeng123");
        Helper hlp = new Helper();

        public List<string> PopulatePatients()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_PatientPopulates", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = hlp.resultHelper(cmd);
            int count = dt.Rows.Count;
            List<string> patients = new List<string>();

            for (int i = 0; i < count; i++)//rows
            {
                patients.Add(dt.Rows[i][0].ToString() + "|" + dt.Rows[i][1].ToString());
            }

            return patients.ToList();
        }
        public List<string> PopulateDoctors()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_PopulateDoctor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = hlp.resultHelper(cmd);
            int count = dt.Rows.Count;
            List<string> doctors = new List<string>();

            for (int i = 0; i < count; i++)//rows
            {
                doctors.Add(dt.Rows[i][0].ToString() + "|" + dt.Rows[i][1].ToString());
            }

            return doctors.ToList();
        }
        public List<string> PopulatePatient()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_PopulatePatient", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dt = hlp.resultHelper(cmd);
            int count = dt.Rows.Count;
            List<string> patient = new List<string>();

            for (int i = 0; i < count; i++)//rows
            {
                patient.Add(dt.Rows[i][0].ToString() + "|" + dt.Rows[i][1].ToString() + "|" + dt.Rows[i][2].ToString());
            }

            return patient.ToList();
        }
        public string PrescribeMedicine(int PatID, int docID, string Prescriptionmessage)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorGetPrescribe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PrescriptionMessage", SqlDbType.VarChar, 250).Value= Prescriptionmessage;
            cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = PatID;
            cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = docID;
            cmd.Parameters.Add("@DayPres", SqlDbType.DateTime).Value = DateTime.Now;

            return hlp.addHelper(cmd, con);
        }
        public string SendMedicalAbstract(int PatID, int docID, string result, string rest, string treat)
        {
            SqlCommand cmd = new SqlCommand("sp_DoctorSendMedAbstract", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Restriction", SqlDbType.VarChar, 50).Value = rest;
            cmd.Parameters.Add("@Treatment", SqlDbType.VarChar, 50).Value = treat;
            cmd.Parameters.Add("@Result", SqlDbType.VarChar, 250).Value = result;
            cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = PatID;
            cmd.Parameters.Add("@DoctorID", SqlDbType.Int).Value = docID;

            return hlp.addHelper(cmd, con);
        }
    }
}
