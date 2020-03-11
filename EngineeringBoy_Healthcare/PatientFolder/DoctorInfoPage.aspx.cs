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
    public partial class DoctorInfoPage : System.Web.UI.Page
    {
        Account acc = new Account();
        Patient pasyente = new Patient();
        Doctor doktor = new Doctor();
        protected void bindGrid()
        {
            DataTable dt = pasyente.ViewDoctors();
            dViewdoctors.DataSource = dt.Copy();
            dViewdoctors.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            else if (!IsPostBack)
            {
                bindGrid();
            }
        }
        protected void btnLogOut(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Home.aspx");
        }
    }
}