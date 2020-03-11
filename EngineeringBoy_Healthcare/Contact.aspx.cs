using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;

namespace EngineeringBoy_Healthcare
{
    public partial class Contact : System.Web.UI.Page
    {
        Admin admin = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {

            string[] contM = admin.GetContact();

            lblContactMessage.Text = contM[0].ToString();
        }
    }
}