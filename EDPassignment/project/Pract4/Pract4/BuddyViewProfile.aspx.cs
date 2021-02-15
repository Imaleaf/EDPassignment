using Pract4.MyDBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddyViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            
            MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
            Buddy buddyObj = client.GetBuddyByName(Session["ssname"].ToString());
            if (buddyObj != null)
            {
                DateTime Birthdate = buddyObj.Birthdate;
                lbl_Age.Text = ComputeAge(Birthdate).ToString();
                lbl_Name.Text = buddyObj.Name.ToString();
                lbl_Location.Text = buddyObj.Location.ToString();
                Image1.ImageUrl = buddyObj.ImagePath;
                lbl_bio.Text = buddyObj.Introduction.ToString();
                lbl_workoutdays.Text = buddyObj.Buddydays.ToString();
                lbl_workoutduration.Text = "Works out " + buddyObj.Buddyduration.ToString() + " per session";
                lbl_gender.Text = "Gender: " + buddyObj.Gender.ToString();
                lbl_workoutType.Text = "Prefers " + buddyObj.Buddyfitness.ToString() + " Fitness";
                string buddyType = buddyObj.Buddytype.ToString();
                string buddyGender = buddyObj.Buddygender.ToString();
                string age1 = buddyObj.Buddyage1.ToString();
                string age2 = buddyObj.Buddyage2.ToString();
                lbl_idealbuddy.Text = "Looking for: " + buddyType + " " + buddyGender + " Workout Buddy aged " + age1 + "-" + age2;
            }
        }

        public int ComputeAge(DateTime Birthdate)
        {
            DateTime now = DateTime.Today;
            int age = DateTime.Today.Year - Birthdate.Year;
            if (now.Month < Birthdate.Month)
            {
                age--;
            }
            else
            {
                if (now.Month == Birthdate.Month && now.Day < Birthdate.Day)
                {
                    age--;
                }
            }
            return age;
        }


        protected void btn_bio_Click(object sender, EventArgs e)
        {
            Session["ssBioEdit"] = lbl_bio.Text;
            Session["ssUserId"] = lbl_Name.Text;
            Response.Redirect("BuddySystemQn5.aspx");
        }

        protected void btn_workoutdays_Click(object sender, EventArgs e)
        {
            Session["ssWorkoutDays"] = lbl_workoutdays.Text;
            Session["ssUserId"] = lbl_Name.Text;
            Response.Redirect("BuddySystemQn9.aspx");
        }

        protected void btn_workoutduration_Click(object sender, EventArgs e)
        {
            Session["ssWorkoutDuration"] = lbl_workoutduration.Text;
            Session["ssUserId"] = lbl_Name.Text;
            Response.Redirect("BuddySystemQn8.aspx");
        }

        protected void btn_gender_Click(object sender, EventArgs e)
        {
            Session["ssGenderEdit"] = lbl_gender.Text;
            Session["ssUserId"] = lbl_Name.Text;
            Response.Redirect("BuddySystemQn2.aspx");
        }

        protected void btn_workoutType_Click(object sender, EventArgs e)
        {
            Session["ssWorkoutTypeEdit"] = lbl_workoutType.Text;
            Session["ssUserId"] = lbl_Name.Text;
            Response.Redirect("BuddySystemQn10.aspx");
        }
    }
}