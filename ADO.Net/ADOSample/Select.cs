using System;
using System.Data;
using System.Data.SqlClient;


namespace AdoSample
{
    internal class Select
    {
        static void Main(string[] args)
        {
            Select.Connection();
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
                    string query = "select * from customer";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine("Id= " + sdr["ID"] +" " +"FirstName= " + sdr["FirstName"] +" "+ "LastName " + sdr["LastName"] + " " + "city " + sdr["City"] +" "+ "country " + sdr["Country"] +" "+ "phone " + sdr["Phone"]);
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