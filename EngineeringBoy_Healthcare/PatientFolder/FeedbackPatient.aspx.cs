using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare.PatientFolder
{
    public partial class FeedbackPatient : System.Web.UI.Page
    {
        Account acc = new Account();
        Patient pasyente = new Patient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
        }
        protected void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            //int custID = int.Parse(act.setCustomerID(int.Parse(Session["userID"].ToString())).ToString());
            if (txtBoxFeedback.Text != String.Empty)
            {
                pasyente.SubmitFeedback(acc.SetPatientID(int.Parse((Session["userID"]).ToString())), txtBoxFeedback.Text);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Feedback submitted.');", true);
                txtBoxFeedback.Text = String.Empty;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Textbox must not be empty.');", true);
            }
        }
    }
}