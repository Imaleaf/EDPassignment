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
    public partial class BookingFormCustomer : System.Web.UI.Page
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

    }
}