using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ssGenderEdit"] != null)
            {
                BtnQ2.Text = "Save";

            }
        }

        protected void BtnQ2_Click(object sender, EventArgs e)
        {
            if (Session["ssBioEdit"] != null)
            {
                if (Qn2RadioBtn.SelectedIndex == 0)
                {
                    string userid = Session["ssUserId"].ToString();
                    MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                    int result = client.UpdateGender(userid, "Male");
                    Response.Redirect("BuddyViewProfile.aspx");
                }

                if (Qn2RadioBtn.SelectedIndex == 1)
                {
                    string userid = Session["ssUserId"].ToString();
                    MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                    int result = client.UpdateGender(userid, "Female");
                    Response.Redirect("BuddyViewProfile.aspx");
                }

            }

            if (Qn2RadioBtn.SelectedIndex == 0)
            {
                Session["ssgender"] = "Male";
            }

            if (Qn2RadioBtn.SelectedIndex == 1)
            {
                Session["ssgender"] = "Female";
            }


            Response.Redirect("BuddySystemQn3.aspx");
        }
    }
}