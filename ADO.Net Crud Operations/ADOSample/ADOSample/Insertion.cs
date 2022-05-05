using System;
using System.Data.SqlClient;

namespace AdoSample
{
    internal class Insertion
    {
        static void Main(string[] args)
        {
            Insertion.Connection();
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
                    Console.WriteLine("employee FirstName:");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("employee LastName:");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("employee Salary:");
                    string SALARY = Console.ReadLine();
                    Console.WriteLine("employee Address:");
                    string Address = Console.ReadLine();
                    Console.WriteLine("employee City:");
                    string city = Console.ReadLine();



                    string query = "insert into customer values(@ID,@FirstName,@LastName,@City, @Country, @Phone )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Country", Country);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    con.Open();
                    var add = cmd.ExecuteNonQuery();
                    if (add > 0)
                    {
                        Console.WriteLine("data inserted successfully");
                    }
                    else
                    {
                        Console.WriteLine("data not inserted");
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