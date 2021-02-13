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
    public partial class EmployeeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }
        private void RefreshGridView()
        {
            List<Employee> eList = new List<Employee>();
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            eList = client.GetAllEmployee().ToList<Employee>();

            // using gridview to bind to the list of employee objects
            gvEmployee.Visible = true;
            gvEmployee.DataSource = eList;
            gvEmployee.DataBind();
        }
        private bool ValidateInput()
        {
            bool result;
            lbMsg.Text = String.Empty;
            lbMsg.ForeColor = Color.Red;
            if (tbNric.Text == "")
            {
                lbMsg.Text += "NRIC is required!" + "<br/>";
            }
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            Employee emp = client.GetEmployeeByNric(tbNric.Text);
            if (emp != null)
            {
                lbMsg.Text += "NRIC already exists!" + "<br/>";
            }
            if (String.IsNullOrEmpty(tbName.Text))
            {
                lbMsg.Text += "Name is required!" + "<br/>";
            }
            result = DateTime.TryParse(tbBirthDate.Text, out DateTime dob);
            if (!result)
            {
                lbMsg.Text += "Birth Date is invalid!" + "<br/>";
            }

            if (ddlDept.SelectedIndex == 0)
            {
                lbMsg.Text += "Department must be selected!" + "<br/>";
            }
            double wage;
            result = double.TryParse(tbMthlySalary.Text, out wage);
            if (!result)
            {
                lbMsg.Text += "Monthly Wage is invalid!" + "<br/>";
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
                DateTime dob = Convert.ToDateTime(tbBirthDate.Text);
                double wage = Convert.ToDouble(tbMthlySalary.Text);

                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                int result = client.CreateEmployee(tbNric.Text, tbName.Text, dob, ddlDept.Text, wage);
                if (result == 1)
                {
                    RefreshGridView();
                    lbMsg.ForeColor = Color.Green;
                    lbMsg.Text = "Employee Record Inserted Successfully!";
                }
                else
                    lbMsg.Text = "SQL Error. Insert Unsuccessful!";
            }
        }

    }
}