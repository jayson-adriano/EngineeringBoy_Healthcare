using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare.PatientFolder
{
    public partial class ProfilePatient : System.Web.UI.Page
    {
        Patient patient = new Patient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            else if (!IsPostBack)
            {
                string[] accountDets = patient.GetDetails(int.Parse(Session["userID"].ToString()));

                txtBoxLastName.Text = accountDets[0].ToString();
                txtBoxfirstName.Text = accountDets[1].ToString();
                txtBoxmiddleName.Text = accountDets[2].ToString();
                txtBoxuserName.Text = accountDets[3].ToString();
                txtBoxpassword.Text = accountDets[4].ToString();
                txtBoxemailAddress.Text = accountDets[5].ToString();
                txtBoxAddress.Text = accountDets[6].ToString();
                txtBirthday.Text = accountDets[7].ToString();
            }
        }


        protected void btnLogOut(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../Home.aspx");
        }
        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {           
            if (txtBoxLastName.Text != String.Empty &&
           txtBoxfirstName.Text != String.Empty &&
           txtBoxmiddleName.Text != String.Empty &&
           txtBoxuserName.Text != String.Empty &&
           txtBoxemailAddress.Text != String.Empty &&
           txtBoxpassword.Text != String.Empty &&
           txtBoxAddress.Text != String.Empty)
            {
               string show = patient.updateProfile(txtBoxLastName.Text, txtBoxfirstName.Text, txtBoxmiddleName.Text, txtBoxuserName.Text, txtBoxpassword.Text, txtBoxemailAddress.Text, txtBoxAddress.Text, int.Parse(Session["userID"].ToString()));

                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Profile edit saved.');", true);
          
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Textbox must not be empty.');", true);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}