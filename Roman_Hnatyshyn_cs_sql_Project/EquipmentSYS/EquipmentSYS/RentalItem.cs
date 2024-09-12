using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EquipmentSYS;
using Oracle.ManagedDataAccess.Client;

namespace EquipmentSYS
{
    class RentalItem
    {
        private int rentalID;
        private int equipmentID;
        private DateTime actualReturnDate;
        private double pricePerEq;


        public RentalItem()
        {
            this.rentalID = 0;
            this.equipmentID = 0;
            this.actualReturnDate = DateTime.Now;
            this.pricePerEq = 0;
        }

        public RentalItem(int rentalID, int equipmentID, DateTime actualReturnDate, double pricePerEq)
        {
            setRentalID(rentalID);
            setEquipmentID(equipmentID);
            setActualReturnDate(actualReturnDate);
            setPricePerEq(pricePerEq); ;
        }

        //getters
        public int getRentalID() { return this.rentalID; }
        public int getEquipmentID() { return this.equipmentID; }
        public DateTime getActualReturnDate() { return this.actualReturnDate; }
        public double getPricePerEq() { return this.pricePerEq; }

        //setters
        public void setRentalID(int RentalID) { rentalID = RentalID; }
        public void setEquipmentID(int EquipmentID) { equipmentID = EquipmentID; }
        public void setActualReturnDate(DateTime ActualReturnDate) { actualReturnDate = ActualReturnDate; }
        public void setPricePerEq(double PricePerEq) { pricePerEq = PricePerEq; }

        public void getRentalItem(int rentalID, int equipmentID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Rentals WHERE RentalID = " + rentalID + " AND EquipmentID = " + equipmentID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setRentalID(dr.GetInt32(0));
            setEquipmentID(dr.GetInt32(1));
            setActualReturnDate(dr.GetDateTime(2));
            setPricePerEq(dr.GetDouble(3));


            //close DB
            conn.Close();
        }

        public void addRentalItem()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO RentalItems (RentalID, EquipmentID, Price_Per_Eq) Values (" +
                this.rentalID + "," +
                this.equipmentID + "," +
                this.pricePerEq + ")";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateRentalItem(int rentalID, int equipmentID)
        {
            String actualReturnDate = this.actualReturnDate.ToString("dd-MMM-yy");
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE RentalItems SET " +
                "Actual_Return_Date = '" + actualReturnDate + "'," +
                "Price_Per_Eq = " + this.pricePerEq +
                "WHERE RentalID = " + rentalID + " AND EquipmentID = " + equipmentID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void deleteRentalItems(int rentalID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "DELETE FROM RentalItems " +
                "WHERE RentalID = " + rentalID ;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public decimal getNewRentalPrice(int rentalID) {

            decimal price = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT SUM(Price_Per_Eq) FROM RentalItems WHERE RentalID = " + rentalID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            price = dr.GetDecimal(0);

            conn.Close();

            return price;
            
        
        }

    }
}