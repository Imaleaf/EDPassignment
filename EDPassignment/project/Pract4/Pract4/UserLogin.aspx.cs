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
using Login = Pract4.MyDBServiceReference.Login;

namespace Pract4
{
    public partial class UserLogin : System.Web.UI.Page
    {
        MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
  

        protected void BtnLogin_Click(object sender, EventArgs e)
        {

            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            UserInfo logObj = client.GetUserInfoByUserID(TbUserID.Text);
            if (logObj != null)
                {
                if (TbPW.Text == logObj.Password)
                {
                    Session["ssUserid"] = TbUserID.Text;
                    Response.Redirect("UserViewProfile.aspx");
                }
                else
                {
                    lbMsg.Text = "Wrong password/ Username";
                }
                }
            else 
            {
                lbMsg.Text = "Wrong password/ Username";
            }
        }
    }
}