using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace BlackBoard_Prem
{
    /* database class created by Alex Creencia, March 26 2020
    * 
    * **NOTE: database class is heavily based on code provided by Dr. Mohamad El-Hajj
    *  
    *  PUBLIC VARIABLE                 DESCRIPTION
    *  
    *  myConnection                    an SqlConnection that contains the connection to the database, this is put in a separate class to maintain the connection between forms
    *  myCommand                       an SqlCommand that is read as an SQL query, because we are sending it to SQL for insert record requests
    *  myReader                        an SqlReader that converts strings to commands that SQL can read
    *  usr                             holds the username of the current user
    */
    public class database
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public string usr;
        public string pass;
        /*
         * Change the myConnection line to include whatever data connection string works with your own local database
         */
        public database(string username, string password)
        {
            /*
             * This is a class constructor version that holds the username. you don't neccessarily need to use this over just the database() constructor, as this was a legacy from 291. Optional
             */
            // ALEX CONNECTION STR
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-I3IEL2R;Initial Catalog='BlackBoard Premium';Integrated Security=True");
            // BirdBrain Connection Str
            //SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-IUI50AL;Initial Catalog='BlackBoard Premium';Integrated Security=True");
            myConnection.Open();    // opens the connection
            usr = username;
            pass = password;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Links the command stream and the connection
            this.myConnection = myConnection;
        }

        public database(string username)
        {
            /*
             * This is a class constructor version that holds the username. you don't neccessarily need to use this over just the database() constructor, as this was a legacy from 291. Optional
             */
            // ALEX CONNECTION STR
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-I3IEL2R;Initial Catalog='BlackBoard Premium';Integrated Security=True");
            // BirdBrain Connection Str
            //SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-IUI50AL;Initial Catalog='BlackBoard Premium';Integrated Security=True");
            myConnection.Open();    // opens the connection
            usr = username;
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Links the command stream and the connection
            this.myConnection = myConnection;
        }
        public database()
        {
            /*
             * Method invoked only once, in order to register a new client, as they will not have a username yet
             */
            // ALEX CONNECTION STR
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-I3IEL2R;Initial Catalog='BlackBoard Premium';Integrated Security=True");
            // BirdBrain Connection STR
            //SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-IUI50AL;Initial Catalog='BlackBoard Premium';Integrated Security=True");
            myConnection.Open();    // opens the connection
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection; // Links the command stream and the connection
            this.myConnection = myConnection;
            //myCommand.CommandType = System.Data.CommandType.StoredProcedure;
        }
        /*
         * Old/Deprecated function for inserting records into a database. This does NOT use a stored procedure, so you will have to comment line #51 in order for this to work as originally intended.
         */
        public void insert(string command)
        {
            myCommand.CommandType = System.Data.CommandType.Text;
            myCommand.CommandText = command;
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
        }
        /*
         * Function line to add parameters to stored procedure safely, to eliminate SQL injections for added security
         */
        public void AddParameter(string parameterName, string actualValue)
        {
            myCommand.Parameters.AddWithValue(parameterName, actualValue);
        }

        public void AddParameter(string parameterName, int actualValue)
        {
            myCommand.Parameters.AddWithValue(parameterName, actualValue);
        }
        public void AddParameter(string parameterName, double actualValue)
        {
            myCommand.Parameters.AddWithValue(parameterName, actualValue);
        }
        public void AddParameter(string parameterName, TimeSpan actualValue)
        {
            myCommand.Parameters.AddWithValue(parameterName, actualValue);
        }
        /*
         * Old/Deprecated function for obtaining records from a database. This was coded WITHOUT stored procedures, so you will have to comment line #51 in order for this to work as originally intended.
         */
        public string query(string command)
        {
            /*
             * because we are expecting something to be returned, we have to make a query function
             * the reader object will hold all the information obtained from the query, thus if it is to be displayed, it will be from the myReader object
             */
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
            myReader.Close();
            myCommand.CommandType = System.Data.CommandType.Text;
            myCommand.CommandText = command;
            //MessageBox.Show(myCommand.CommandText);

            //myReader = myCommand.ExecuteReader();
            string userID = myCommand.ExecuteScalar().ToString();
            return userID;
            //myCommand.CommandType = CommandType.StoredProcedure;
        }
        /*
         * This functions nearly identical to query, except this explicitly says for storedProcedures. 
         * Also Parameters are cleared after executing, so you will have to re-add parameters again if you want to redo the SP immediately
         */
        public void executeSP(string StoredProcedureName)
        {
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }
            myCommand.CommandText = StoredProcedureName;
            myReader = myCommand.ExecuteReader();
            myCommand.Parameters.Clear();
            //myReader.Close();
        }

        public void executeSPsingle(string StoredProcedureName)
        {
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }
            myCommand.CommandText = StoredProcedureName;
            myCommand.ExecuteScalar();

        }
    }
}
