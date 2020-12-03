using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataLayer
{
    public class BooksRepository
    {

        private static string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Book> GetAllBooks()
        {
            List<Book> results = new List<Book>();

            using(SqlConnection conn = new SqlConnection(connString)) {
                SqlCommand comm = new SqlCommand {
                    Connection = conn,
                    CommandText = "SELECT * FROM Books",
                };
                conn.Open();
                SqlDataReader dataReader = comm.ExecuteReader();

                while(dataReader.Read())
                {
                    Book book = new Book {
                        Id = dataReader.GetInt32(0),
                        Name = dataReader.GetString(1),
                        Author = dataReader.GetString(2),
                        Year = dataReader.GetInt32(3)
                    };
                    results.Add(book);
                }
            }

            return results;
        }

        public int insertBook(Book b)
        {
            using(SqlConnection conn = new SqlConnection(connString)) {
                SqlCommand comm = new SqlCommand {
                    Connection = conn,
                    CommandText = $"INSERT INTO Books VALUES ('{b.Name}', '{b.Author}', {b.Year})"
                };
                conn.Open();

                return comm.ExecuteNonQuery();
            }
        }
    }
}
