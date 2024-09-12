using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EquipmentSYS;
using Oracle.ManagedDataAccess.Client;

namespace EquipmentSYS
{
    class Equipment
    {
        private int equipmentID;
        private String eqName;
        private String serialNumber;
        private String description;
        private decimal rate;
        private String categoryID;


        public Equipment()
        {
            this.equipmentID = 0;
            this.eqName = "";
            this.serialNumber = "";
            this.description = "";
            this.rate = 0;
            this.categoryID = "";
        }

        public Equipment(int equipmentID, string eqName, string serialNumber, string description, decimal rate, string categoryID)
        {
            setEquipmentID(equipmentID);
            setEqName(eqName);
            setSerialNumber(serialNumber);
            setDescription(description);
            setRate(rate);
            setCategoryID(categoryID);
        }

        //getters
        public int getEquipmentID() { return this.equipmentID; }
        public String getEqName() { return this.eqName; }
        public String getSerialNumber() { return this.serialNumber; }
        public String getDescription() { return this.description; }
        public decimal getRate() { return this.rate; }
        public String getCategoryID() { return this.categoryID; }

        //setters
        public void setEquipmentID(int EquipmentID) { equipmentID = EquipmentID; }
        public void setEqName(String Name) { eqName = Name; }
        public void setSerialNumber(String SerialNumber) { serialNumber = SerialNumber; }
        public void setDescription(String Description) { description = Description; }
        public void setRate(Decimal Rate) { rate = Rate; }
        public void setCategoryID(String CategoryID) { categoryID = CategoryID; }

        public static DataSet getAllEquipment()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT EquipmentID, Name, Serial_Number, Description, Rate " +
                "FROM Equipment ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "equipment");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getAllEquipment(String categoryID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT EquipmentID, Name, Serial_Number, Description, Rate " +
                "FROM Equipment WHERE CategoryID = '" + categoryID + "' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "equipment");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getEquipment(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Equipment WHERE EquipmentID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setEquipmentID(dr.GetInt32(0));
            setEqName(dr.GetString(1));
            setSerialNumber(dr.GetString(2));
            setDescription(dr.GetString(3));
            setRate(dr.GetDecimal(4));
            setCategoryID(dr.GetString(5));

            //close DB
            conn.Close();
        }
        public void addEquipment()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Equipment Values (" +
                this.equipmentID + ",'" +
                this.eqName + "','" +
                this.serialNumber + "','" +
                this.description + "'," +
                this.rate + ",'" +
                this.categoryID + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateEquipment(int id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Equipment SET " +
                "EquipmentID = " + this.equipmentID + "," +
                "Name = '" + this.eqName + "'," +
                "Serial_Number = '" + this.serialNumber + "'," +
                "Description = '" + this.description + "'," +
                "Rate = " + this.rate + "," +
                "CategoryID = '" + this.categoryID + "' " +
                "WHERE EquipmentID = " + id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static int getNextEquipmentID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(EquipmentID) FROM Equipment";

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
