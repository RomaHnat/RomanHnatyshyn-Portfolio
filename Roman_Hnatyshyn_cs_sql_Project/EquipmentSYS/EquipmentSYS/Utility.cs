using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EquipmentSYS
{
    internal class Utility
    {
        public static void loadCategoryData(ComboBox cboName)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT * FROM Categories";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + " - " + dr.GetString(1));
            }
            conn.Close();
        }

        public static void loadEquipmentDataUpdateEquipment(ComboBox cboName, String category)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT * FROM Equipment " +
                            "WHERE CategoryID = '" + category + "' " +
                            "AND NOT EXISTS (SELECT 1 FROM RentalItems " +
                            "WHERE Equipment.equipmentID = RentalItems.equipmentID " +
                            "AND Actual_Return_Date IS NULL)"; 
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0).PadLeft(6, '0') + " - " + dr.GetString(1) + " - " + dr.GetString(2) + " - " + dr.GetDecimal(4).ToString() + "/day");
            }
            conn.Close();
        }

        public static void loadAllRentalItemsCmb(ComboBox equipments, int rentalID)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT * FROM Equipment JOIN RentalItems ON Equipment.equipmentID = RentalItems.equipmentID WHERE RentalItems.rentalID = " + rentalID + " AND RentalItems.Actual_Return_Date IS NULL";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                equipments.Items.Add(dr.GetString(0).PadLeft(6, '0') + " - " + dr.GetString(1) + " - " + dr.GetString(2) + " - " + dr.GetDecimal(4).ToString() + "/day\n");
            }
            conn.Close();
        }

        public static void loadAllRentalItemsCart(RichTextBox equipments, int rentalID)
        {
            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT * FROM Equipment JOIN RentalItems ON Equipment.equipmentID = RentalItems.equipmentID WHERE RentalItems.rentalID = " + rentalID;
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                equipments.Text += dr.GetString(0).PadLeft(6, '0') + " - " + dr.GetString(1) + " - " + dr.GetString(2) + " - " + dr.GetDecimal(4).ToString() + "/day\n";
            }
            conn.Close();
        }

        public static void loadEquipmentDataPlaceRental(ComboBox cboName, String category, DateTime collectionDate, DateTime returnDate) 
        {
            String strSQL =


                "SELECT EquipmentID, Name, Serial_Number, Rate " +
                "FROM Equipment " +
                "WHERE EquipmentID NOT IN( " +
                    "SELECT ri.EquipmentID " +
                    "FROM Rentals r " +
                    "JOIN RentalItems ri ON r.RentalID = ri.RentalID " +
                    "JOIN Equipment e ON e.EquipmentID = ri.EquipmentID " +
                    "WHERE( " +
                        "(r.Return_Date >= '" + returnDate.ToString("dd-MMM-yy") + "'AND r.Collection_Date <= '" + returnDate.ToString("dd-MMM-yy") + "') " +
                        "OR " +
                        "(r.Return_Date >=  '" + collectionDate.ToString("dd-MMM-yy") + "'AND r.Collection_Date <= '" + collectionDate.ToString("dd-MMM-yy") + "') " +
                        "OR " +
                        "(r.Return_Date <= '" + returnDate.ToString("dd-MMM-yy") + "' AND r.Collection_Date >= '" + collectionDate.ToString("dd-MMM-yy") + "')" +
                    ")" +
                    ")" +
                    "AND CategoryID = '" + category + "' " +
                    "ORDER BY EquipmentID";

   
            
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0).PadLeft(6, '0') + " - " + dr.GetString(1) + " - " + dr.GetString(2) + " - " + dr.GetDecimal(3).ToString() + "/day");
            }
            conn.Close();
        }

        public static void fillYearsComboBox(ComboBox years) {

            String strSQL = "SELECT DISTINCT EXTRACT(YEAR FROM Return_Date) AS Year FROM Rentals ORDER BY Year DESC";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                years.Items.Add(dr.GetString(0));
            }
            conn.Close();


        }


    }

}

