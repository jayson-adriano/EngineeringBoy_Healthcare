using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare
{
    public partial class ReactivateAccount : System.Web.UI.Page
    {
        Account acc = new Account();
        Patient pasyente = new Patient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnReactivate_Click(object sender, EventArgs e)
        {
            Session["userID"] = acc.logIn(txtboxUsername.Text.ToString(), txtboxPassword.Text.ToString());

            if (txtboxUsername.Text == String.Empty || txtboxPassword.Text == String.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Username or Password must not be empty!');", true);
                txtboxUsername.Text = String.Empty;
                txtboxPassword.Text = String.Empty;
            }
            else if (int.Parse(Session["userID"].ToString()) == -1) //??
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
            else if (int.Parse(Session["userID"].ToString()) < 4) //ADMIN
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('This is an admin account!');", true);
                txtboxPassword.Text = String.Empty;
                txtboxUsername.Text = String.Empty;
            }
            else
            {
                txtboxPassword.Text = String.Empty;
                txtboxUsername.Text = String.Empty;
                pasyente.ReactivateAccount(int.Parse(Session["userID"].ToString()));
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Account Reactivated!');", true);
                Response.Redirect("~/PatientFolder/ProfilePatient.aspx");
            }

        }
    }
}