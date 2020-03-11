using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dllFiles;

namespace EngineeringBoy_Healthcare.PatientFolder
{
    public partial class PrescriptionPatient : System.Web.UI.Page
    {
        Account acc = new Account();
        Patient pasyente = new Patient();
        protected void bindGrid()
        {
            DataTable dt = pasyente.ViewPrescriptions(int.Parse(Session["userID"].ToString()));
            dViewPrescriptions.DataSource = dt.Copy();
            dViewPrescriptions.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            bindGrid();
        }
        protected void btnLogOut(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Home.aspx");
        }
    }
}