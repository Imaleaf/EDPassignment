using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnQ6_Click(object sender, EventArgs e)
        {
            string strList = "";
            for (int i = 0; i < Qn6ChkBox.Items.Count; i++)
            {
                if (Qn6ChkBox.Items[i].Selected)
                {
                    strList = strList + Qn6ChkBox.Items[i].Value + ",";
                }
            }
            if (strList.Length > 0)
            {
                strList = strList.TrimEnd(',');
            }

            Session["ssbuddytype"] = strList;
            Response.Redirect("BuddySystemQn7.aspx");
        }
    }
}