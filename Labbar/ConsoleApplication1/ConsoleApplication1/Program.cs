using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        public static string ConnectionString { get; set; }
        static SqlConnection SqlConnection { get; set; }

        public static void Run()
        {
            SqlConnection = new SqlConnection();
            ConnectionString = @"data Source=(local);
                    Initial Catalog = Books;
                    User = Jacc; Password = sockan;
                    Integrated Security = True";

            PrintAllAuthors();
           

            Console.Write("Delete Author with ID:");
            int id = int.Parse(Console.ReadLine());
            DeleteAuthor(id);
            PrintAllAuthors();
            
        }
        static void PrintAllAuthors()
        {
            var list = GetAllAuthors();
            foreach (var A in list)
            {
                Console.WriteLine(A);
            }
            Console.ReadKey();
        }
        static void OpenConnection(string connectionstring)
        {
            SqlConnection.ConnectionString = connectionstring;
            SqlConnection.Open();
        }
        static void CloseConnection()
        {
            SqlConnection.Close();
            SqlConnection.Dispose();
        }
        static void InsertAuthor(Author author)
        {
            OpenConnection(ConnectionString);
            string sql = "Insert Into Authors (FirstName, LastName) Values('" + author.FirstName + "','" + author.LastName + "')";
            using (SqlCommand command = new SqlCommand(sql, SqlConnection))
            {
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
        static void InsertAuthor(string fName, string lName)
        {
            OpenConnection(ConnectionString);
            string sql = "Insert Into Authors (FirstName, LastName) Values('" + fName + "','" + lName + "')";
            using (SqlCommand command = new SqlCommand(sql, SqlConnection))
            {
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }
        static void UpdateAuthorLastName(string lastName, int ID)
        {
            OpenConnection(ConnectionString);
            string sql = "Update Authors Set LastName = '" + lastName + "' Where AuthorID = '" + ID + "'";

            using (SqlCommand command = new SqlCommand(sql, SqlConnection))
            {
                command.ExecuteNonQuery();
            }
            CloseConnection();

        }
        static void DeleteAuthor(int ID)
        {
            OpenConnection(ConnectionString);
            string sql = "Delete From Authors Where AuthorID = '" + ID + "'";

            using (SqlCommand command = new SqlCommand(sql, SqlConnection))
            {
                Console.WriteLine(command.ExecuteNonQuery());
            }
            CloseConnection();
        }
        public static void ShowConnectionStatus(SqlConnection Connection)
        {
            Console.WriteLine("");
            Console.WriteLine("Source:             " + Connection.DataSource);
            Console.WriteLine("Database:           " + Connection.Database);
            Console.WriteLine("Connection TimeOut: " + Connection.ConnectionTimeout);
            Console.WriteLine("Current State:      " + Connection.State);
            Console.WriteLine("\nConnectionString: " + Connection.ConnectionString);
            Console.WriteLine(Connection.WorkstationId);
            Console.WriteLine("");
        }
        public static void AddAuthor()
        {

            Console.WriteLine("FirstName: ");
            String fName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            string lName = Console.ReadLine();

            using (SqlConnection Connection = new SqlConnection())
            {
                Connection.ConnectionString =
                    @"data Source=(local);
                    Initial Catalog = Books;
                    User = Jacc Password = sockan;
                    Integrated Security = True";
                Connection.Open();

                string sql =
                    "Insert Into Authors (FirstName, Lastname) Values('" + fName + "','" + lName + "')";
                SqlCommand instertCmd = new SqlCommand(sql, Connection);

                if (instertCmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Authors table has been updated!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("GDM! you screwed up!");
                }
            }
        }
        static List<Author> GetAllAuthors()
        {
            OpenConnection(ConnectionString);
            List<Author> authorList = new List<Author>();
            string sql = "Select * From Authors";

            using (SqlCommand command = new SqlCommand(sql, SqlConnection))
            {
                SqlDataReader DR = command.ExecuteReader();
                while (DR.Read())
                {
                    authorList.Add(new Author
                    {
                        AuthorID = (int)DR["AuthorID"],
                        FirstName = (string)DR["FirstName"],
                        LastName = (string)DR["LastName"],
                    });
                }
            }
            CloseConnection();
            return authorList;
        }

        static void Main(string[] args)
        {
            Run();
        }



    }

}

