using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare.PatientFolder
{
    public partial class DeactivatePatient : System.Web.UI.Page
    {
        Patient pasyente = new Patient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
        }

        protected void btnOKDeact_Click(object sender, EventArgs e)
        {
            pasyente.DeactivateAccount(int.Parse(Session["userID"].ToString()));
            Response.Redirect("../SessionExpired.aspx");
        }

        protected void btnCancelDeact_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Deactivation is cancelled.');", true);
            Response.Redirect("../PatientFolder/ProfilePatient.aspx");
        }

    }
}