using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;
namespace EngineeringBoy_Healthcare.AdminPage
{
    public partial class HomeAdmin : System.Web.UI.Page
    {
        Admin admin = new Admin();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            else
            if (!IsPostBack)
            {
                string[] contM = admin.GetContact();
                txtContact.Text = contM[0].ToString();
                //TextArea1.InnerText = 
                string[] abtM = admin.GetAbout();
                txtAbout.Text = abtM[0].ToString();
            }
        }


        protected void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            
           if (txtContact.Text != String.Empty || txtAbout.Text != String.Empty)
            {
                admin.SubmitEditInformation(txtAbout.Text, txtContact.Text);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Information edited.');", true);
                
               string[] contM = admin.GetContact();
                txtContact.Text = contM[0].ToString();
            //    txtContact2.Text = contM[1].ToString();

                string[] abtM = admin.GetAbout();
                txtAbout.Text = abtM[0].ToString();
             //   txtAbout2.Text = abtM[1].ToString();
           }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Textbox must not be empty.');", true);
            }
        }
    }

}