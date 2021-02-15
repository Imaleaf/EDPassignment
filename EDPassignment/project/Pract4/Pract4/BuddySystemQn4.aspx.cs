using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnQ4_Click(object sender, EventArgs e)
        {
            Session["sslocation"] = TbQn4.Text;
            Response.Redirect("BuddySystemPicture.aspx");
        }
    }
}