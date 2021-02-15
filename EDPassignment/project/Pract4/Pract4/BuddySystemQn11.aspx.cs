using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnQ11_Click(object sender, EventArgs e)
        {
            string name = Session["ssname"].ToString();
            string gender = Session["ssgender"].ToString();
            DateTime dob = Convert.ToDateTime(Session["ssbday"].ToString());
            string location = Session["sslocation"].ToString();
            string introduction = Session["ssintro"].ToString();
            string buddytype = Session["ssbuddytype"].ToString();
            string buddygender = Session["ssbuddygender"].ToString();
            string buddyduration = Session["ssbuddyduration"].ToString();
            string buddydays = Session["ssbuddydays"].ToString();
            string buddyfitness = Session["ssbuddyfitness"].ToString();
            string filename = Session["ssImagePath"].ToString();
            string imagename = filename;
            string imagepath = "Images/" + filename;
            double buddyage1 = Convert.ToDouble(Qn11Tb1.Text);
            double buddyage2 = Convert.ToDouble(Qn11Tb2.Text);

            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            int result = client.CreateBuddy(name, gender, dob, location, introduction, buddytype, buddygender, buddyduration, buddydays, buddyfitness, buddyage1, buddyage2, imagename, imagepath);

            Response.Redirect("BuddyViewProfile.aspx");
        }
    }
}