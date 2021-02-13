using Pract4.MyDBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Pract4
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        protected void LoadCustomer()
        {
            //MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            //Customer cusObj = client.GetCustomerById(tbCustId.Text);
            //if (cusObj != null)
            //{
            //    PanelErrorResult.Visible = false;
            //    PanelCust.Visible = true;
            //    Lbl_custname.Text = cusObj.Name;
            //    Lbl_Address.Text = cusObj.Address + "<br/>";
            //    Lbl_Address.Text += "Singapore " + cusObj.Postal;
            //    Lbl_HomePhone.Text = cusObj.HomePhone;
            //    Lbl_Mobile.Text = cusObj.Mobile;
            //    Lbl_err.Text = String.Empty;
            //}
            //else
            //{
            //    Lbl_err.Text = "Customer record not found!";
            //    PanelErrorResult.Visible = true;
            //    PanelCust.Visible = false;
            //    Lbl_custname.Text = String.Empty;
            //    Lbl_Address.Text = String.Empty;
            //    Lbl_HomePhone.Text = String.Empty;
            //    Lbl_Mobile.Text = String.Empty;
            //    HyplinkAdd.Visible = false;
            //}
        }
    }
}