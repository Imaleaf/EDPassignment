using Pract4.MyDBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pract4
{
    public partial class BuddyDiscoverProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["i"] != null)
            {
                int i = Convert.ToInt32(Session["i"].ToString());
                List<Buddy> eList = new List<Buddy>();
                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                eList = client.GetAllBuddy().ToList<Buddy>();
                listNum.Text = i.ToString();
                DateTime Birthdate = eList[i].Birthdate;
                lbl_Age.Text = ComputeAge(Birthdate).ToString();
                lbl_Name.Text = eList[i].Name.ToString();
                lbl_Location.Text = eList[i].Location.ToString();
                Image1.ImageUrl = eList[i].ImagePath;
                lbl_bio.Text = eList[i].Introduction.ToString();
                lbl_workoutdays.Text = eList[i].Buddydays.ToString();
                lbl_workoutduration.Text = "Works out " + eList[i].Buddyduration.ToString() + " per session";
                lbl_gender.Text = "Gender: " + eList[i].Gender.ToString();
                lbl_workoutType.Text = "Prefers " + eList[0].Buddyfitness.ToString() + " Fitness";
                string buddyType = eList[i].Buddytype.ToString();
                string buddyGender = eList[i].Buddygender.ToString();
                string age1 = eList[i].Buddyage1.ToString();
                string age2 = eList[i].Buddyage2.ToString();
                lbl_idealbuddy.Text = "Looking for: " + buddyType + " " + buddyGender + " Workout Buddy aged " + age1 + "-" + age2;
            }
            else
            {
                int i = 0;
                List<Buddy> eList = new List<Buddy>();
                MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                eList = client.GetAllBuddy().ToList<Buddy>();
                listNum.Text = i.ToString();
                DateTime Birthdate = eList[i].Birthdate;
                lbl_Age.Text = ComputeAge(Birthdate).ToString();
                lbl_Name.Text = eList[i].Name.ToString();
                lbl_Location.Text = eList[i].Location.ToString();
                Image1.ImageUrl = eList[i].ImagePath;
                lbl_bio.Text = eList[i].Introduction.ToString();
                lbl_workoutdays.Text = eList[i].Buddydays.ToString();
                lbl_workoutduration.Text = "Works out " + eList[i].Buddyduration.ToString() + " per session";
                lbl_gender.Text = "Gender: " + eList[i].Gender.ToString();
                lbl_workoutType.Text = "Prefers " + eList[0].Buddyfitness.ToString() + " Fitness";
                string buddyType = eList[i].Buddytype.ToString();
                string buddyGender = eList[i].Buddygender.ToString();
                string age1 = eList[i].Buddyage1.ToString();
                string age2 = eList[i].Buddyage2.ToString();
                lbl_idealbuddy.Text = "Looking for: " + buddyType + " " + buddyGender + " Workout Buddy aged " + age1 + "-" + age2;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(listNum.Text) + 1;
            Session["i"] = i;
            Response.Redirect("BuddyDiscoverProfile.aspx");
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
    }
}