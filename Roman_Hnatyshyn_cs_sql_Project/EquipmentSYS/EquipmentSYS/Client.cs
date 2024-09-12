using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EquipmentSYS;
using Oracle.ManagedDataAccess.Client;

namespace EquipmentSYS
{
    class Client
    {
        private int clientID;
        private String firstName;
        private String secondName;
        private String mobileNumber;
        private String email;
        private String status;


        public Client()
        {
            this.clientID = 0;
            this.firstName = "";
            this.secondName = "";
            this.mobileNumber = "";
            this.email = "";
            this.status = "A";
        }

        public Client(int clientID, String firstName, String secondName, String mobileNumber, String email, String status)
        {
            setClientID(clientID);
            setFirstName(firstName);
            setSecondName(secondName);
            setMobileNumber(mobileNumber);
            setEmail(email);
            setStatus(status);
        }

        //getters
        public int getClientID() { return this.clientID; }
        public String getFirstName() { return this.firstName; }
        public String getSecondName() { return this.secondName; }
        public String getMobileNumber() { return this.mobileNumber; }
        public String getEmail() { return this.email; }
        public String getStatus() { return this.status; }

        //setters
        public void setClientID(int ClientID) { clientID = ClientID; }
        public void setFirstName(String FirstName) { firstName = FirstName; }
        public void setSecondName(String SecondName) { secondName = SecondName; }
        public void setMobileNumber(String MobileNumber) { mobileNumber = MobileNumber; }
        public void setEmail(String Email) { email = Email; }
        public void setStatus(String Status) { status = Status; }

        public void getClient(String email)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Clients WHERE Email_Address = '" + email + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setClientID(dr.GetInt32(0));
            setFirstName(dr.GetString(1));
            setSecondName(dr.GetString(2));
            setMobileNumber(dr.GetString(3));
            setEmail(dr.GetString(4));
            setStatus(dr.GetString(5));

            //close DB
            conn.Close();
        }
        public void addClient()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Clients Values (" +
                this.clientID + ",'" +
                this.firstName + "','" +
                this.secondName + "','" +
                this.mobileNumber + "','" +
                this.email + "','" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateClient(String email)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Clients SET " +
                "ClientID = " + this.clientID + "," +
                "First_Name = '" + this.firstName + "'," +
                "Second_Name = '" + this.secondName + "'," +
                "Mobile_Number = '" + this.mobileNumber + "'," +
                "Email_Address = '" + this.email + "'," +
                "Client_Status = '" + this.status + "' " +
                "WHERE Email_Address = '" + email + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static int getNextClientID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(ClientID) FROM Clients";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }
    }
}
