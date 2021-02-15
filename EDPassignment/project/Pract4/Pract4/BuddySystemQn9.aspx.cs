﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddySystemQn9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ssWorkoutDays"] != null)
            {
                BtnQ9.Text = "Save";

            }
        }

        protected void BtnQ9_Click(object sender, EventArgs e)
        {
            if (Session["ssWorkoutDays"] != null)
            {
                string strList2 = "";
                for (int i = 0; i < Qn9ChkBox.Items.Count; i++)
                {
                    if (Qn9ChkBox.Items[i].Selected)
                    {
                        strList2 = strList2 + Qn9ChkBox.Items[i].Value + ",";
                    }
                }
                if (strList2.Length > 0)
                {
                    strList2 = strList2.TrimEnd(',');
                }

                string userid = Session["ssUserId"].ToString();

                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                int result = client.UpdateWorkoutDays(userid, strList2);
                Response.Redirect("BuddyViewProfile.aspx");
            }

            string strList = "";
            for (int i = 0; i < Qn9ChkBox.Items.Count; i++)
            {
                if (Qn9ChkBox.Items[i].Selected)
                {
                    strList = strList + Qn9ChkBox.Items[i].Value + ",";
                }
            }
            if (strList.Length > 0)
            {
                strList = strList.TrimEnd(',');
            }

            Session["ssbuddydays"] = strList;
            Response.Redirect("BuddySystemQn10.aspx");
        }
    }
}