using Microsoft.Ajax.Utilities;
using Pract4.MyDBServiceReference;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BookingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }
        private void RefreshGridView()
        {
            List<Booking> eList = new List<Booking>();
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            eList = client.GetAllBooking().ToList<Booking>();

            // using gridview to bind to the list of employee objects
            gvBooking.Visible = true;
            gvBooking.DataSource = eList;
            gvBooking.DataBind();
        }
        private bool ValidateInput()
        {
            bool result;
            lbMsg.Text = String.Empty;
            lbMsg.ForeColor = Color.Red;
            if (tbFacilityID.Text == "")
            {
                lbMsg.Text += "Facility ID is required!" + "<br/>";
            }
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            Booking book = client.GetBookingByFacilityID(tbFacilityID.Text);
            if (book != null)
            {
                lbMsg.Text += "Facility ID already exists!" + "<br/>";
            }
            if (String.IsNullOrEmpty(tbFacilityName.Text))
            {
                lbMsg.Text += "Facility Name is required!" + "<br/>";
            }
            DateTime date;
            result = DateTime.TryParse(tbDate.Text, out date);
            if (!result)
            {
                lbMsg.Text += "Date is invalid!" + "<br/>";
            }

            if (ddlDuration.SelectedIndex == 0)
            {
                lbMsg.Text += "Duration must be selected!" + "<br/>";
            }

            if (ddlSport.SelectedIndex == 0)
            {
                lbMsg.Text += "Sport must be selected!" + "<br/>";
            }

            double price;
            result = double.TryParse(tbPrice.Text, out price);
            if (!result)
            {
                lbMsg.Text += "Price ($) is invalid!" + "<br/>";
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
                DateTime date = Convert.ToDateTime(tbDate.Text);
                double price = Convert.ToDouble(tbPrice.Text);

                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                int result = client.CreateBooking(tbFacilityID.Text, tbFacilityName.Text, ddlSport.Text, date, ddlDuration.Text, price);
                if (result == 1)
                {
                    RefreshGridView();
                    lbMsg.ForeColor = Color.Green;
                    lbMsg.Text = "Booking Record Inserted Successfully!";
                }
                else
                    lbMsg.Text = "SQL Error. Insert Unsuccessful!";
            }
        }

    }
}