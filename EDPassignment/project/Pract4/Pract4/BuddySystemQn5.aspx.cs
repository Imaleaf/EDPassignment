using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ssBioEdit"] != null)
            {
                BtnQ5.Text = "Save";

            }
        }

        protected void BtnQ5_Click(object sender, EventArgs e)
        {
            if (Session["ssBioEdit"] != null)
            {
                string introduction = Qn5Tb1.Text;
                string userid = Session["ssUserId"].ToString();
                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                int result = client.UpdateIntroduction(userid, introduction);
                Response.Redirect("BuddyViewProfile.aspx");
            }
            Session["ssintro"] = Qn5Tb1.Text;
            Response.Redirect("BuddySystemQn6.aspx");
        }
    }
}