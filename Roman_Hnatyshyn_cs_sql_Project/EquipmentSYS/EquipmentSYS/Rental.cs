using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EquipmentSYS;
using Oracle.ManagedDataAccess.Client;

namespace EquipmentSYS
{
    class Rental
    {
        private int rentalID;
        private DateTime collectionDate;
        private DateTime returnDate;
        private decimal price;
        private String status;
        private int clientID;


        public Rental()
        {
            this.rentalID = 0;
            this.collectionDate = DateTime.Now;
            this.returnDate = DateTime.Today.AddDays(1);
            this.price = 0;
            this.status = "R";
            this.clientID = 0;
        }

        public Rental(int rentalID, DateTime collectionDate, DateTime returnDate, decimal price, String status, int clientID)
        {
            setRentalID(rentalID);
            setCollectionDate(collectionDate);
            setReturnDate(returnDate);
            setPrice(price);
            setStatus(status);
            setClientID(clientID);
        }

        //getters
        public int getRentalID() { return this.rentalID; }
        public DateTime getCollectionDate() { return this.collectionDate; }
        public DateTime getReturnDate() { return this.returnDate; }
        public decimal getPrice() { return this.price; }
        public String getStatus() { return this.status; }
        public int getClientID() { return this.clientID; }

        //setters
        public void setRentalID(int RentalID) { rentalID = RentalID; }
        public void setCollectionDate(DateTime CollectionDate) { collectionDate = CollectionDate; }
        public void setReturnDate(DateTime ReturnDate) { returnDate = ReturnDate; }
        public void setPrice(decimal Price) { price = Price; }
        public void setStatus(String Status) { status = Status; }
        public void setClientID(int ClientID) { clientID = ClientID; }

        public void getRental(int rentalID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Rentals WHERE RentalID = " + rentalID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setRentalID(dr.GetInt32(0));
            setClientID(dr.GetInt32(1));
            setCollectionDate(dr.GetDateTime(2));
            setReturnDate(dr.GetDateTime(3));
            setPrice(dr.GetDecimal(4));
            setStatus(dr.GetString(5));

            //close DB
            conn.Close();
        }
        public void addRental()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String collectionDate = this.collectionDate.ToString("dd-MMM-yy");
            String returnDate = this.returnDate.ToString("dd-MMM-yy");

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Rentals Values (" +
                this.rentalID + ", '" +
                this.clientID + "','" +
                collectionDate + "', '" +
                returnDate + "', " +
                this.price + ",'" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateRental()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            String returnDate = this.returnDate.ToString("dd-MMM-yy");

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Rentals SET " +
                "Return_Date = '" + returnDate + "'," +
                "Status = '" + this.status + "'," +
                "Price = " + this.price +
                "WHERE RentalID = " + this.rentalID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static int getNextRentalID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(RentalID) FROM Rentals";

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

        public void cancelRental()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "DELETE FROM  Rentals " +
                "WHERE RentalID = " + this.rentalID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }


    }
}