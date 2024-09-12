using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using EquipmentSYS;

namespace EquipmentSYS
{
    class Category
    {
        private String categoryID;
        private String catName;
        private String catDescription;


        public Category(String categoryID, String catName, String catDescription)
        {
            setCategoryID(categoryID);
            setCatName(catName);
            setCatDescription(catDescription);
        }

        public Category()
        {
        }

        //getters
        public String getCategoryID() { return this.categoryID; }
        public String getCatName() { return this.catName; }
        public String getCatDescription() { return this.catDescription; }

        //setters
        public void setCategoryID(String CategoryID) { categoryID = CategoryID; }
        public void setCatName(String Name) { catName = Name; }
        public void setCatDescription(String Description) { catDescription = Description; }

        public static DataSet getAllCategories()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CategoryID, Name, Description " +
                "FROM Categories ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "category");

            //Close db connection
            conn.Close();

            return ds;
        }
        public static DataSet getAllCategories(String categoryID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT CategoryID, Name, Description " +
                "FROM Categories WHERE CategoryID = '" + categoryID + "' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "category");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void getCategory(String Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Categories WHERE CategoryID = '" + Id + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setCategoryID(dr.GetString(0));
            setCatName(dr.GetString(1));
            setCatDescription(dr.GetString(2));


            //close DB
            conn.Close();
        }
        public void addCategory()
        {
            // Open a db connection
            using (OracleConnection conn = new OracleConnection(DBConnect.oraDB))
            {
                // Define the SQL query with parameters
                String sqlQuery = "INSERT INTO Categories VALUES (:categoryID, :catName, :catDescription)";

                // Execute the SQL query with parameters
                using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
                {
                    // Add parameters and their values
                    cmd.Parameters.Add(new OracleParameter("categoryID", this.categoryID));
                    cmd.Parameters.Add(new OracleParameter("catName", this.catName));
                    cmd.Parameters.Add(new OracleParameter("catDescription", this.catDescription));

                    // Open the connection and execute the query
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }

        public void updateCategory(String id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Categories SET " +
                "CategoryID = '" + this.categoryID + "'," +
                "Name = '" + this.catName + "'," +
                "Description = '" + this.catDescription + "'" +
                "WHERE CategoryID = '" + id + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
    }
}