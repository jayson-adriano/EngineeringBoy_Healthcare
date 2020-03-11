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
    public partial class PatientAbstract : System.Web.UI.Page
    {
        Patient pasyente = new Patient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            DataTable dt = pasyente.ViewAbstract(int.Parse(Session["userID"].ToString()));
            dViewAbstract.DataSource = dt.Copy();
            dViewAbstract.DataBind();

        }


    }
}