using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComputerStore
{
    class SQLConnect
    {
        string myconnectionstring = "user id=Eric-PC\\Eric;" +
                                       "password=;server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=Product; " +
                                       "connection timeout=30";
        public SQLConnect()
        {

        }

        public SqlConnection SQLconnect()
        {
            /*SqlConnection myConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=database; " +
                                       "connection timeout=30");*/
            SqlConnection myConnection = new SqlConnection(myconnectionstring);
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return myConnection;
        }

        public void insertintoDatabase(SqlConnection myConnection, string query)
        {
            // SqlCommand myCommand = new SqlCommand("Command String", myConnection);

            SqlCommand myCommand = new SqlCommand("INSERT INTO table (Column1, Column2) " +
                                     "Values ('string', 1)", myConnection);
            myCommand.ExecuteNonQuery();
        }

        public string QueryDatabase(SqlConnection myConnection, string query)
        {
            string result="";
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(query,myConnection);
                myCommand.CommandText = query;
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    string firstcolumn = myReader["empid"].ToString();
                    string secondcolumn = myReader["firstname"].ToString();

                    result+=firstcolumn + " " + secondcolumn;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return result;
        }
    }
}
