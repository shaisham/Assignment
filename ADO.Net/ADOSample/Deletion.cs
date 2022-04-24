using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoSample
{
    internal class Deletion
    {
        static void Main(string[] args)
        {
            Deletion.Connection();
            Console.ReadKey();
        }

        static void Connection()
        {
            string cs = "Data Source=KINGEXPT\\SQLEXPRESS;Initial Catalog=customers;Integrated Security=true;";
            //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            // SqlConnection con = new SqlConnection(cs);
            SqlConnection con = null;

            try

            {
                using (con = new SqlConnection(cs))
                {
                    Console.WriteLine("employee ID:");
                    string ID = Console.ReadLine();

                    // deletion
                    string query = "delete from Employee2 where id= @ID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    con.Open();
                    var add = cmd.ExecuteNonQuery();
                    if (add > 0)
                    {
                        Console.WriteLine("data deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("data not deleted");
                    }

                }

            }
            catch (SqlException ex)

            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

    }
}



//to check connection established or not in try
//con.Open();
//if (con.State == ConnectionState.Open)
//{
//    Console.WriteLine("connection created successfully");
//}