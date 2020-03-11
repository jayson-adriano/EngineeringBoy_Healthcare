using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dllFiles;

namespace EngineeringBoy_Healthcare.DoctorFolder
{
    public partial class MessageDoctor : System.Web.UI.Page
    {
        Account acc = new Account();
        Patient pasyente = new Patient();
        Doctor doktor = new Doctor();
        protected void bindGrid()
        {
            DataTable dt = pasyente.ViewDoctorMessages(int.Parse(Session["userID"].ToString()));
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
                    ddPatient.Items.Clear();
                    ddPatient.DataSource = doktor.PopulatePatients();
                    ddPatient.DataBind();
                    bindGrid();
                }
        }
        protected void btnLogOut(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Home.aspx");
        }
        protected void btnSubmitChat_Click(object sender, EventArgs e)
        {
            string str = ddPatient.SelectedItem.ToString();
            string[] pat = str.Split('|');

            if (txtBoxChat.Text != String.Empty)
            {
                pasyente.SendChatDoctor(acc.SetDoctorID(int.Parse((Session["userID"]).ToString())), txtBoxChat.Text, pat[0].ToString());
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