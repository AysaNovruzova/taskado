
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;

namespace taskadonet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string con = "server= DESKTOP-80LIQDV\\SQLEXPRESS01"; database = adonet; Trusted_connection = true; integrated security = true;
            //    using (SqlConnection connektion = new SqlConnection(con))
            //    {
            //        connektion.Open();

            //        string command = "insert into users values ('Student') ";
            //        SqlCommand cmd = new SqlCommand(command, connektion);
            //        int result = cmd.ExecuteNonQuery();
            //        if (result > 0)
            //        {
            //            Console.WriteLine("data elave olundu");
            //        }
            //        else
            //        {
            //            Console.WriteLine("mueyyen bir problem bas verdi");
            //        }

            //        string query = "selekt * from users";

            //        SqlDataAdapter adapter = new SqlDataAdapter (query, connektion);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);

            //        foreach (DataRow item in dataTable.Rows) 
            //        {
            //            Console.WriteLine(item[0]+" "+ item[1]);
            //        }

            //    }
            //}
        }
    }

}