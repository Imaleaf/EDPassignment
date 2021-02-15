﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ssWorkoutTypeEdit"] != null)
            {
                BtnQ10.Text = "Save";

            }
        }

        protected void BtnQ10_Click(object sender, EventArgs e)
        {
            if (Session["ssWorkoutTypeEDIT"] != null)
            {
                string strList2 = "";
                for (int i = 0; i < Qn10ChkBox.Items.Count; i++)
                {
                    if (Qn10ChkBox.Items[i].Selected)
                    {
                        strList2 = strList2 + Qn10ChkBox.Items[i].Value + ",";
                    }
                }
                if (strList2.Length > 0)
                {
                    strList2 = strList2.TrimEnd(',');
                }

                string userid = Session["ssUserId"].ToString();

                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                int result = client.UpdateWorkoutType(userid, strList2);
                Response.Redirect("BuddyViewProfile.aspx");
            }

            string strList = "";
            for (int i = 0; i < Qn10ChkBox.Items.Count; i++)
            {
                if (Qn10ChkBox.Items[i].Selected)
                {
                    strList = strList + Qn10ChkBox.Items[i].Value + ",";
                }
            }
            if (strList.Length > 0)
            {
                strList = strList.TrimEnd(',');
            }

            Session["ssbuddyfitness"] = strList;
            Response.Redirect("BuddySystemQn11.aspx");
        }
    }
}
