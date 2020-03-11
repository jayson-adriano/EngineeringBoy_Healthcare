using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare
{
    public partial class Home : System.Web.UI.Page
    {
        Account acc = new Account();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["userID"] = acc.logIn(txtboxUsername.Text.ToString(), txtboxPassword.Text.ToString());
            string doc = acc.CheckDoctorExist(int.Parse(Session["userID"].ToString()));


            if (txtboxUsername.Text == String.Empty || txtboxPassword.Text == String.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Username or Password must not be empty!');", true);
                txtboxUsername.Text = String.Empty;
                txtboxPassword.Text = String.Empty;
            }
            else if (int.Parse(Session["userID"].ToString()) == -1) //invalid account blanks
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Invalid account details.');", true);
                txtboxPassword.Text = String.Empty;
                txtboxUsername.Text = String.Empty;
            }
            else if (int.Parse(Session["userID"].ToString()) == -2) //USERNAME NOT EXISTING
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Username does not exist.');", true);
                txtboxUsername.Text = String.Empty;
                txtboxPassword.Text = String.Empty;
            }
            else if (int.Parse(Session["userID"].ToString()) == -3) //DID NOT MATCH
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Username and Password does not match.');", true);
                txtboxPassword.Text = String.Empty;
                txtboxUsername.Text = String.Empty;
            }
            else if (int.Parse(Session["userID"].ToString()) < 4 && !chkPatient.Checked) //ADMIN
            {
                Response.Redirect("~/AdminPage/HomeAdmin.aspx");
            }
            else if (!chkPatient.Checked && (doc == "doctor")) //DOCTOR
            {
                Label1.Text = doc;
                txtboxPassword.Text = String.Empty;
                txtboxUsername.Text = String.Empty;
                Response.Redirect("~/DoctorFolder/MessageDoctor.aspx");
            }
            else if (chkPatient.Checked && (doc == "doctor"))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Please uncheck the Patient.');", true);
                //Label1.Text = doc;
            }
            else if (chkPatient.Checked)//PATIENT
            {
                string deac = acc.CheckIfDeactivated(int.Parse(Session["userID"].ToString())).ToString();
                //check if account is deactivated

                if (deac == "True") //deactivated
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Account deactivated. Reactivate account to log in.');", true);

                    txtboxPassword.Text = String.Empty;
                    txtboxUsername.Text = String.Empty;
                }
                else
                {
                    txtboxPassword.Text = String.Empty;
                    txtboxUsername.Text = String.Empty;
                    Response.Redirect("~/PatientFolder/ProfilePatient.aspx");
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Please click Patient checkbox if you are a patient.');", true);
            }
        }

    }
}