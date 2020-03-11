using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare.DoctorFolder
{
    public partial class MedicalAbstractDoctor : System.Web.UI.Page
    {

        Account acc = new Account();
        Patient pasyente = new Patient();
        Doctor doktor = new Doctor();

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
                    ddPatient.DataSource = doktor.PopulatePatient();
                    ddPatient.DataBind();
                }

        }

        protected void btnAbstract_Click(object sender, EventArgs e)
        {
            string str = ddPatient.SelectedItem.ToString();
            string[] pat = str.Split('|');

            //check if remarks is empty
            if (txtResult.Text == String.Empty || txtTreatment.Text == String.Empty || txtRestriction.Text == String.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Textfields must not be empty!.');", true);
            }
            else
            {

                string res = doktor.SendMedicalAbstract(int.Parse(pat[0].ToString()), int.Parse((Session["userID"]).ToString()), txtResult.Text, txtRestriction.Text, txtTreatment.Text);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Medical Abstract sent.');", true);
                txtResult.Text = String.Empty;
                txtTreatment.Text = String.Empty;
                txtRestriction.Text = String.Empty;
            }
        }

        protected void btnLogOut(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Home.aspx");
        }

    }
}
