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
    public partial class TermDepositForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string custId = string.Empty;
            //if (!Page.IsPostBack)
            //{
            //    // Display customer Id and Name using session variables
            //    if (Session["SScustId"] != null)
            //    {
            //        lbCustId.Text = Session["SScustId"].ToString();
            //        lbCustname.Text = Session["SScustName"].ToString();
            //    }

            //    MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            //    List<TDRate> rateList = client.GetAllTDRate().ToList();

            //    ddlTerm.Items.Clear();
            //    ddlTerm.Items.Insert(0, new ListItem("--Select--", "0"));
            //    //AppendDataBoundItems property allows you to add items to the ListControl object before data binding occurs.
            //    ddlTerm.AppendDataBoundItems = true;

            //    // set Term as the dropdown list text and intRate as the dropdown list values
            //    // set the rateList as the DataSource and invoked the DataBind() method.
            //    ddlTerm.DataTextField = "Term";
            //    ddlTerm.DataValueField = "Rate";
            //    ddlTerm.DataSource = rateList;
            //    ddlTerm.DataBind();
            //}
        }

        //protected void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    String account = tbNewAcno.Text.ToString();
        //    String custId = lbCustId.Text.ToString();
        //    double principal = Convert.ToDouble(tbPrincipal.Text.ToString());
        //    int term = Convert.ToInt32(ddlTerm.SelectedItem.Text.ToString());
        //    DateTime mDate = Convert.ToDateTime(lbMaturedDate.Text);
        //    double interest = Convert.ToDouble(lbInterest.Text.ToString());
        //    double mAmt = Convert.ToDouble(lbMaturedAmt.Text);
        //    double rate = Convert.ToSingle(ddlTerm.SelectedValue);
        //    string mode = ddlRenew.SelectedItem.Text;

        //    MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
        //    int cnt = client.CreateTDMaster(account, custId, principal, term, interest, mDate, mAmt, rate, mode);
        //    if (cnt == 1)
        //    {
        //        lbResult.Text = "Term Deposit Created Successfully!";
        //        lbResult.ForeColor = Color.Green;
        //        btnConfirm.Enabled = false;
        //    }
        //    else
        //    {
        //        lbResult.Text = "Unable to create term deposit. Please inform system administrator!";
        //        lbResult.ForeColor = Color.Red;
        //    }
        //    btnConfirm.Enabled = false;
        //}

        //protected void ddlTerm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    double fmPrincipal;
        //    DateTime fmMatureDate;
        //    double fmInterest, fmMatureAmt;
        //    int fmTerm;
        //    double fmIntRate;
        //    lbErr1.Text = "";
        //    lbErr2.Text = "";
        //    if (ddlTerm.SelectedIndex > 0)
        //    {
        //        try
        //        {
        //            fmPrincipal = Convert.ToDouble(tbPrincipal.Text);
        //            fmIntRate = Convert.ToSingle(ddlTerm.SelectedValue);
        //            fmTerm = Convert.ToInt32(ddlTerm.SelectedItem.Text);

        //            fmMatureAmt = CalculateMaturity(fmPrincipal, fmTerm, fmIntRate);

        //            fmInterest = Math.Round((fmMatureAmt - fmPrincipal), 1);
        //            fmMatureDate = DateTime.Now.AddMonths(fmTerm);

        //            lbRate.Text = ddlTerm.SelectedValue;

        //            lbMaturedDate.Text = fmMatureDate.ToString();
        //            lbInterest.Text = fmInterest.ToString();
        //            lbMaturedAmt.Text = fmMatureAmt.ToString();
        //        }
        //        catch (FormatException)
        //        {
        //            lbErr1.Text = "Please input an numeric dollar amount!";
        //        }
        //    }
        //    else
        //    {
        //        lbErr2.Text = "Select a valid term!";
        //    }
        //}
        //// This method calculates the matured amount based on the formula.
        //public double CalculateMaturity(double fmPrincipal, int fmTerm, double fmIntRte)
        //{
        //    // A = P x (1 + r/n)nt note that nt is to the power of 
        //    // r is annual interest rate (1.5% per annual is 0.015)
        //    // n - number of time interest compounded. Monthly compounding, n will be 12
        //    //     half yearly compounding will be 2, quarter compounding, n will be 4
        //    //     This practical assume quarter compounding
        //    // t - number of months
        //    int n = 4;
        //    double r = fmIntRte / 100;
        //    int t = fmTerm;
        //    int nt = n * t / 12;
        //    double fmMaturity = fmPrincipal * Math.Pow((1 + (r / n)), nt);
        //    fmMaturity = Math.Round(fmMaturity, 1);
        //    return fmMaturity;
        //}
    }
}