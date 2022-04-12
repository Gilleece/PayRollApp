using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Xml;

namespace PayRollApp
{
    public class dbConnector
    {

        private static SQLiteConnection sqlconnConnection;
        public DataSet myAppDataSet = new DataSet();


        public dbConnector(string strFilePath)
        {
            try
            {
                sqlconnConnection = new SQLiteConnection("Data Source=" + strFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception("DbConnector initialisation unsuccessful:\n" + ex.Message);
            }
        }

        public bool checkCredentials(string userID, string password)
        {
            try
            {
                DataTable dtCount = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT COUNT() FROM users WHERE userID = @userID AND password = @password;";
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@userID", userID);
                sqlcomCommand.Parameters.AddWithValue("@password", password);
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);


                try
                {
                    sqldatadptAdapter.Fill(dtCount);
                    if (dtCount.Rows[0][0].ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Exception will the "thrown"/Raised when there was a problem
                    throw new Exception($"SELECT unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // exception thrown for the whole method or function    
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }

        public bool checkIfAdmin(string userID)
        {
            try
            {
                DataTable dtUser = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT * FROM users WHERE userID = @userID;"; 
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@userID", userID);
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);


                try
                {
                    sqldatadptAdapter.Fill(dtUser);
                    if (dtUser.Rows[0][2].ToString() == "TRUE")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Exception will the "thrown"/Raised when there was a problem
                    throw new Exception($"SELECT unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // exception thrown for the whole method or function    
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }

        public DataTable getUserDetails(string userID)
        {
            try
            {
                DataTable dtAccountDetails = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT * FROM users WHERE userID = @userID;";  // example of a Paramaterised SQL statement.
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@userID", userID);
                //sqlcomCommand.Parameters.AddWithValue("@mysenderguid", strSenderGuid); // passing parameters into the SQL command
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);  // local SQL data Adaptor


                try
                {
                    sqldatadptAdapter.Fill(dtAccountDetails);
                    return dtAccountDetails;
                }
                catch (Exception ex)
                {
                    // Exception will the "thrown"/Raised when there was a problem
                    throw new Exception($"SELECT unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // exception thrown for the whole method or function    
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }

        public DataTable getAllUserDetails()
        {
            try
            {
                DataTable dtAccountDetails = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT * FROM users;";  // example of a Paramaterised SQL statement.
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                //sqlcomCommand.Parameters.AddWithValue("@mysenderguid", strSenderGuid); // passing parameters into the SQL command
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);  // local SQL data Adaptor


                try
                {
                    sqldatadptAdapter.Fill(dtAccountDetails);
                    return dtAccountDetails;
                }
                catch (Exception ex)
                {
                    // Exception will the "thrown"/Raised when there was a problem
                    throw new Exception($"SELECT unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // exception thrown for the whole method or function    
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }

        public DataTable getAllTours()
        {
            try
            {
                DataTable dtAccountDetails = new DataTable();
                sqlconnConnection.Open();
                string strQuery = @"SELECT * FROM tours;";  // example of a Paramaterised SQL statement.
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strQuery, sqlconnConnection);
                //sqlcomCommand.Parameters.AddWithValue("@mysenderguid", strSenderGuid); // passing parameters into the SQL command
                SQLiteDataAdapter sqldatadptAdapter = new SQLiteDataAdapter(sqlcomCommand);  // local SQL data Adaptor


                try
                {
                    sqldatadptAdapter.Fill(dtAccountDetails);
                    return dtAccountDetails;
                }
                catch (Exception ex)
                {
                    // Exception will the "thrown"/Raised when there was a problem
                    throw new Exception($"SELECT unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // exception thrown for the whole method or function    
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }

        public void updateDetails(string accNum, string name, string eircode, string pin)
        {
            try
            {
                sqlconnConnection.Open();
                string strInsert = @"UPDATE accounts SET fullName = @name, eircode = @eircode, pin = @pin WHERE accountNo = @accNum;";
                SQLiteCommand sqlcomCommand = new SQLiteCommand(strInsert, sqlconnConnection);
                sqlcomCommand.Parameters.AddWithValue("@accNum", accNum);
                sqlcomCommand.Parameters.AddWithValue("@name", name);
                sqlcomCommand.Parameters.AddWithValue("@eircode", eircode);
                sqlcomCommand.Parameters.AddWithValue("@pin", pin);

                try
                {
                    sqlcomCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"UPDATE unsuccessful:\n{ex.Message}");
                }
                finally
                {
                    sqlconnConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"User(string):\n{ex.Message}");
            }


            sqlconnConnection.Close();

        }
    }
}

