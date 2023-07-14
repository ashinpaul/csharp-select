using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {
        private static object user;

        static void Main(string[] args)
        {
            string connectorString = "server=localhost";user = root;database = Sys;port = 3306;password = rajagiri;
            string query = "select *from mytable 50";

            try
            {
                connection.open();
                adapter.Fill(dataSet, "mytable50");
                DataTable datatable = dataSet.Tables["mytable50"];
                foreach (DataRow row in dataTable.Rows)
                {
                    int id = (int)row["id"];
                    string name = (string)row["Sname"];
                    Console.WriteLine($"ID:{id},Name:{name}");
                }
            }catch(Exception e) { Console.WriteLine(e); }
        }
    }
}
