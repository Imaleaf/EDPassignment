using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnQ3_Click(object sender, EventArgs e)
        {
            Session["ssbday"] = Qn3tbBday.Text;
            Response.Redirect("BuddySystemQn4.aspx");
        }
    }
}