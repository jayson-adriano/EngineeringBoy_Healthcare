using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dllFiles;
namespace EngineeringBoy_Healthcare
{
    public partial class About : System.Web.UI.Page
    {
        Admin admin = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] aboutM = admin.GetAbout();

            lblAboutMessage.Text = aboutM[0].ToString();
        }
    }
}