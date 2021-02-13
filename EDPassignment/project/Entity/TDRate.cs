using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MyDBService.Entity
{
    public class TDRate
    {
        public int Term { get; set; }
        public double Rate { get; set; }

        public TDRate()
        {
        }
        public TDRate(int term, double rate)
        {
            this.Term = term;
            this.Rate = rate;
        }

        public List<TDRate> SelectAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT tdTerm, tdRate From TDRate " +
                             "WHERE GETDATE() between tdEffFrom and tdEffTo";

            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            List<TDRate> rateList = new List<TDRate>();

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 0)
            {
                rateList = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int term = Convert.ToInt32(row["tdTerm"]);
                    float rate = Convert.ToSingle(row["tdRate"]);
                    TDRate objRate = new TDRate(term, rate);
                    rateList.Add(objRate);
                }
            }
            return rateList;
        }
    }
}
