using Pract4.MyDBServiceReference;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class UserViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userid = Session["ssUserid"].ToString();


            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            UserInfo logObj = client.GetUserInfoByUserID(userid);
            if (logObj != null)
            {

                lbl_name.Text = logObj.Name;
                lbl_dob.Text = logObj.Dob.ToString();
                lbl_contact.Text = logObj.Contact;
                lbl_email.Text = logObj.Email;
                lbl_country.Text = logObj.Country;
                lbl_city.Text = logObj.City;



            }
            else
            {
            
            }

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            string userid = Session["ssUserid"].ToString();
            Response.Redirect("~/UserLogin.aspx");

        }
    }
}