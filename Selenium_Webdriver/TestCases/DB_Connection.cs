using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Selenium_Webdriver.TestCases
{
    class DB_Connection
    {
        static void Main(string[] args)
        {
            //SqlConnection conn = new SqlConnection("Server=.\\LAPTOP-V0QHNVJR;Database=MortgageHouse;Integrated Security=true");
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=MortgageHouse;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Effective , Term, Loan from dbo.All_Home", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{1},{0}", reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            conn.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }

        }
           

            
    }
}
