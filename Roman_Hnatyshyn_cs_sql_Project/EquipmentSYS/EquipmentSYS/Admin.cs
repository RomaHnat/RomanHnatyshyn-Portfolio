using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EquipmentSYS
{
    internal class Admin
    {

        public static void yearlyRevenue(Chart report, int selectedYear)
        {
            String[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
            decimal[] money = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            String strSQl =
                "SELECT EXTRACT(MONTH FROM Return_Date) AS Month, SUM(Price) AS TotalPrice " +
                "FROM Rentals " + 
                "WHERE Status = 'R' AND EXTRACT(YEAR FROM Return_Date) = " + selectedYear +
                " GROUP BY EXTRACT(MONTH FROM Return_Date) " +
                "ORDER BY EXTRACT(MONTH FROM Return_Date)";

            DataTable dr = new DataTable();

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQl, conn);
            //execute the command using an Oracle DataReader

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dr);

            conn.Close();

            for (int i = 0; i < dr.Rows.Count; i++)
            {
                money[Convert.ToInt32(dr.Rows[i][0]) - 1] = Convert.ToDecimal(dr.Rows[i][1]);

            }

            report.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            report.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            report.ChartAreas[0].AxisX.Interval = 1;
            report.Series[0].LegendText = "Income in €";
            report.Series[0].Points.DataBindXY(months, money);
            report.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            report.Series[0].Label = "#VALY";

            report.Titles.Add("Yearly Revenue");

        }

        public static void categoryProfit(RichTextBox report, int selectedYear) { 
        
            report.Clear();

            string strSQL = "SELECT c.CategoryID, c.Name, " +
                "SUM(ri.Price_Per_Eq) AS Profit " +
                "FROM Categories c " +
                "JOIN Equipment e ON c.CategoryID = e.CategoryID " +
                "JOIN RentalItems ri ON e.EquipmentID = ri.EquipmentID " +
                "JOIN Rentals r ON ri.RentalID = r.RentalID " +
                "WHERE EXTRACT(YEAR FROM ri.Actual_Return_Date) = " + selectedYear  +
                "AND ri.Actual_Return_Date IS NOT NULL " +
                "GROUP BY c.CategoryID, c.Name " +
                "ORDER BY c.CategoryID";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader

            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {

                String categoryID = dr.GetString(0);
                String categoryName = dr.GetString(1); 
                decimal profit = dr.GetDecimal(2);

                report.AppendText("\n" + categoryID + " - " + categoryName + ": " + profit + "\n");

            }

        }

    }
}
