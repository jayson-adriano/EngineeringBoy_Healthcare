using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;
using System.Data;


namespace EngineeringBoy_Healthcare.PatientFolder
{
    public partial class PatientChat : System.Web.UI.Page
    {
        Account acc = new Account();
        Patient pasyente = new Patient();
        Doctor doktor = new Doctor();
        protected void bindGrid()
        {
            DataTable dt = pasyente.ViewMessages(int.Parse(Session["userID"].ToString()));
            dViewMessages.DataSource = dt.Copy();
            dViewMessages.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            else
            if (!IsPostBack)
            {
                ddDoctor.Items.Clear();
                ddDoctor.DataSource = doktor.PopulateDoctors();
                ddDoctor.DataBind();
                bindGrid();
            }

        }

        protected void btnSubmitChat_Click(object sender, EventArgs e)
        {
            string str = ddDoctor.SelectedItem.ToString();
            string[] doc = str.Split('|');

            if (txtBoxChat.Text != String.Empty)
            {
                pasyente.SendChat(acc.SetPatientID(int.Parse((Session["userID"]).ToString())), txtBoxChat.Text, doc[0].ToString());
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Message sent.');", true);
                txtBoxChat.Text = String.Empty;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Chatbox must not be empty.');", true);
            }
        }
    }
}