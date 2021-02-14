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
    public partial class UserSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {

            List<UserInfo> eList = new List<UserInfo>();
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            eList = client.GetAllUserInfo().ToList<UserInfo>();

            // using gridview to bind to the list of employee objects
            //gvUserInfo.Visible = true;
           //gvUserInfo.DataSource = eList;
            //gvUserInfo.DataBind();


        }

        private bool ValidateInput()
        {
            bool result;
            lbMsg.Text = String.Empty;
            lbMsg.ForeColor = Color.Red;
            if (TbUserID.Text == "")
            {
                lbMsg.Text += "UserID is required!" + "<br/>";
            }
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            UserInfo info = client.GetUserInfoByUserID(TbUserID.Text);
            if (info != null)
            {
                lbMsg.Text += "User ID already exists!" + "<br/>";
            }
            if (String.IsNullOrEmpty(TbName.Text))
                {
                    lbMsg.Text += "Name is required!" + "<br/>";
                }
            DateTime date;
            result = DateTime.TryParse(TbDOB.Text, out date);
            if (!result)
            {
                lbMsg.Text += "Date is invalid!" + "<br/>";
            }
            if (String.IsNullOrEmpty(TbNo.Text))
            {
                lbMsg.Text += "Contact is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(TbEmail.Text))
            {
                lbMsg.Text += "Email is required!" + "<br/>";
            }
            if (DropDownList.SelectedIndex == 0)
            {
                lbMsg.Text += "Country must be selected!" + "<br/>";
            }
            if (String.IsNullOrEmpty(TbCity.Text))
            {
                lbMsg.Text += "City is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(Tbpostal.Text))
            {
                lbMsg.Text += "PostalCode is required!" + "<br/>";
            }

            if (String.IsNullOrEmpty(TbPW.Text))
            {
                lbMsg.Text += "PASSWORD is required!" + "<br/>";
            }

            if (String.IsNullOrEmpty(lbMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            bool validInput = ValidateInput();

            if (validInput)
            {
                DateTime date = Convert.ToDateTime(TbDOB.Text);


                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                int result = client.CreateUserInfo(TbName.Text, date, TbNo.Text, TbEmail.Text, DropDownList.Text, TbCity.Text, Tbpostal.Text, TbUserID.Text, TbPW.Text);
                if (result == 1)
                {
                    RefreshGridView();
                    lbMsg.ForeColor = Color.Green;
                    lbMsg.Text = "User Signed Up Successfully!";
                    Response.Redirect("~/UserLogin.aspx");
                }
                else
                    lbMsg.Text = "SQL Error. Sign Up Unsuccessful!";
            }
        }
    }
}