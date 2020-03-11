using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using dllFiles;

namespace EngineeringBoy_Healthcare
{
    public partial class Register : System.Web.UI.Page
    {
        Account acc = new Account();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.SelectedDate == DateTime.MinValue)
                {
                    this.PopulateYear();
                    this.PopulateMonth();
                    this.PopulateDay();
                }
            }
            else
            {
                if (Request.Form[ddlDay.UniqueID] != null)
                {
                    this.PopulateDay();
                    ddlDay.ClearSelection();
                    ddlDay.Items.FindByValue(Request.Form[ddlDay.UniqueID]).Selected = true;
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtDocCode.Text == String.Empty) //REGISTER AS PATIENT
            {
                if (txtBoxLastName.Text != String.Empty &&
           txtBoxfirstName.Text != String.Empty &&
           txtBoxmiddleName.Text != String.Empty &&
           txtBoxuserName.Text != String.Empty &&
           txtBoxemailAddress.Text != String.Empty &&
           txtBoxpassword.Text != String.Empty &&
           txtBoxAddress.Text != String.Empty &&
           SelectedDate != null)
                {
                    string check = acc.registerAccount(txtBoxLastName.Text, txtBoxfirstName.Text, txtBoxmiddleName.Text, txtBoxuserName.Text, txtBoxpassword.Text, txtBoxemailAddress.Text, txtBoxAddress.Text, SelectedDate);
                    if (check == "no")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Username already exists.');", true);
                        txtBoxuserName.Text = String.Empty;
                        txtBoxpassword.Text = String.Empty;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Account membership request sent. Please wait for the approval of the administrator.');", true);
                        txtBoxLastName.Text = String.Empty;
                        txtBoxfirstName.Text = String.Empty;
                        txtBoxmiddleName.Text = String.Empty;
                        txtBoxuserName.Text = String.Empty;
                        txtBoxpassword.Text = String.Empty;
                        txtBoxemailAddress.Text = String.Empty;
                        txtBoxAddress.Text = String.Empty;
                    }

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Please fill in the missing details.');", true);
                }
            }
            else if (txtDocCode.Text == "ABCD1234" || txtDocCode.Text == "EFGH5678" || txtDocCode.Text == "WXYZ9999") //REGISTER AS DOCTOR
            {
                if (txtBoxLastName.Text != String.Empty &&
           txtBoxfirstName.Text != String.Empty &&
           txtBoxmiddleName.Text != String.Empty &&
           txtBoxuserName.Text != String.Empty &&
           txtBoxemailAddress.Text != String.Empty &&
           txtBoxpassword.Text != String.Empty &&
           txtBoxAddress.Text != String.Empty &&
           SelectedDate != null)
                {
                    string check = acc.registerDoctorAccount(txtBoxLastName.Text, txtBoxfirstName.Text, txtBoxmiddleName.Text, txtBoxuserName.Text, txtBoxpassword.Text, txtBoxemailAddress.Text, txtBoxAddress.Text, SelectedDate, txtSpecialization.Text);
                    if (check == "no")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Username already exists.');", true);
                        txtBoxuserName.Text = String.Empty;
                        txtBoxpassword.Text = String.Empty;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Your Account is already registered as a doctor!');", true);
                        txtBoxLastName.Text = String.Empty;
                        txtBoxfirstName.Text = String.Empty;
                        txtBoxmiddleName.Text = String.Empty;
                        txtBoxuserName.Text = String.Empty;
                        txtBoxpassword.Text = String.Empty;
                        txtBoxemailAddress.Text = String.Empty;
                        txtBoxAddress.Text = String.Empty;
                        txtSpecialization.Text = String.Empty;
                    }

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Please fill in the missing details.');", true);
                }
            }
            else //WRONG DOC CODE 
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowStatus", "javascript:alert('Wrong doctor code. Please try again.');", true);
                txtDocCode.Text = String.Empty;
            }


        }

        private int Day
        {
            get
            {
                if (Request.Form[ddlDay.UniqueID] != null)
                {
                    return int.Parse(Request.Form[ddlDay.UniqueID]);
                }
                else
                {
                    return int.Parse(ddlDay.SelectedItem.Value);
                }
            }
            set
            {
                this.PopulateDay();
                ddlDay.ClearSelection();
                ddlDay.Items.FindByValue(value.ToString()).Selected = true;
            }
        }
        private int Month
        {
            get
            {
                return int.Parse(ddlMonth.SelectedItem.Value);
            }
            set
            {
                this.PopulateMonth();
                ddlMonth.ClearSelection();
                ddlMonth.Items.FindByValue(value.ToString()).Selected = true;
            }
        }
        private int Year
        {
            get
            {
                return int.Parse(ddlYear.SelectedItem.Value);
            }
            set
            {
                this.PopulateYear();
                ddlYear.ClearSelection();
                ddlYear.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        public DateTime SelectedDate
        {
            get
            {
                try
                {
                    return DateTime.Parse(this.Month + "/" + this.Day + "/" + this.Year);
                }
                catch
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if (!value.Equals(DateTime.MinValue))
                {
                    this.Year = value.Year;
                    this.Month = value.Month;
                    this.Day = value.Day;
                }
            }
        }

        private void PopulateDay()
        {
            ddlDay.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "DD";
            lt.Value = "0";
            ddlDay.Items.Add(lt);
            int days = DateTime.DaysInMonth(this.Year, this.Month);
            for (int i = 1; i <= days; i++)
            {
                lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                ddlDay.Items.Add(lt);
            }
            ddlDay.Items.FindByValue(DateTime.Now.Day.ToString()).Selected = true;
        }

        private void PopulateMonth()
        {
            ddlMonth.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "MM";
            lt.Value = "0";
            ddlMonth.Items.Add(lt);
            for (int i = 1; i <= 12; i++)
            {
                lt = new ListItem();
                lt.Text = Convert.ToDateTime(i.ToString() + "/1/1900").ToString("MMMM");
                lt.Value = i.ToString();
                ddlMonth.Items.Add(lt);
            }
            ddlMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }

        private void PopulateYear()
        {
            ddlYear.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "YYYY";
            lt.Value = "0";
            ddlYear.Items.Add(lt);
            for (int i = DateTime.Now.Year; i >= 1950; i--)
            {
                lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                ddlYear.Items.Add(lt);
            }
            ddlYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
        }

    }
}