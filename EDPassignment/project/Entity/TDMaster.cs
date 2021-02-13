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
    public class TDMaster
    {
        public string Account { get; set; }
        public string CustId { get; set; }
        public double Principal { get; set; }
        public int Term { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime MaturityDate { get; set; }
        public double Interest { get; set; }
        public double MaturedAmt { get; set; }
        public double Rate { get; set; }
        public string RenewMode { get; set; }

        public TDMaster()
        {
        }
        public TDMaster(string acc, string id, double principal, int term, double interest, DateTime mDate, double mAmt, double rate, string mode)
        {
            Account = acc;
            CustId = id;
            Principal = principal;
            Term = term;
            Interest = interest;
            MaturityDate = mDate;
            MaturedAmt = mAmt;
            Rate = rate;
            RenewMode = mode;
        }
        public int Insert()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO TDMaster (account, custId, principal, term, " +
                                    "effectFrom, maturity,interestAmt,matureAmt,tdRate,renewMode)" +
                             "VALUES (@paraAccount,@paraCustId,@paraPrincipal,@paraTerm," +
                                    "GETDATE(),@paraMaturity,@paraInterest,@paraMatureAmt,@paraTdRate,@paraRenewMode)";

            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraAccount", Account);
            sqlCmd.Parameters.AddWithValue("@paraCustId", CustId);
            sqlCmd.Parameters.AddWithValue("@paraPrincipal", Principal);
            sqlCmd.Parameters.AddWithValue("@paraTerm", Term);
            sqlCmd.Parameters.AddWithValue("@paraMaturity", MaturityDate);
            sqlCmd.Parameters.AddWithValue("@paraInterest", Interest);
            sqlCmd.Parameters.AddWithValue("@paraMatureAmt", MaturedAmt);
            sqlCmd.Parameters.AddWithValue("@paraTdRate", Rate);
            sqlCmd.Parameters.AddWithValue("@paraRenewMode", RenewMode);

            myConn.Open();
            // Execute NonQuery return an integer value
            int result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        public List<TDMaster> SelectByCustId(string custId)
        {
            List<TDMaster> tdList = new List<TDMaster>();
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "SELECT * From TDMaster where custId = @paraId " +
                            "and maturity >= GETDATE()";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", custId);

            DataSet ds = new DataSet();
            da.Fill(ds);

            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string acc = row["account"].ToString();
                    double principal = Convert.ToDouble(row["principal"]);
                    int term = Convert.ToInt32(row["term"]);
                    DateTime effFrom = Convert.ToDateTime(row["effectFrom"]);
                    DateTime mDate = Convert.ToDateTime(row["maturity"]);
                    double interest = Convert.ToDouble(row["interestAmt"]);
                    double mAmt = Convert.ToDouble(row["matureAmt"]);
                    double rate = Convert.ToSingle(row["tdRate"]);
                    string mode = (string)row["renewMode"];

                    TDMaster td = new TDMaster(acc, custId, principal, term, interest, mDate, mAmt, rate, mode)
                    {
                        EffectiveFrom = effFrom
                    };
                    tdList.Add(td);
                }
            }
            else
            {
                tdList = null;
            }
            
            return tdList;
        }

        public TDMaster SelectByAccount(string account)
        {
            // Hardcoded Data
            string custId = "S*******D";
            double principal = 50000;
            int term = 3;
            double rate = 1.5;
            double interest = principal * rate / 100;
            DateTime mDate = DateTime.Now.AddMonths(term);
            double mAmt = principal + interest;
            string mode = "Not renewing";

            TDMaster td1 = new TDMaster(account, custId, principal, term, interest, mDate, mAmt, rate, mode)
            {
                EffectiveFrom = DateTime.Now
            };
            return td1;
        }
        public int UpdateByAccount(string acc, string renewMode)
        {
            int result = 0;
            // Add your codes here

            return result;
        }
    }
}
