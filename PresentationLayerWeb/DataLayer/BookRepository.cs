using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BookRepository
    {

        public List<Book> getAllBooks()
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Books";
                List<Book> books = new List<Book>();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Book b = new Book();
                    b.Id = sqlDataReader.GetInt32(0);
                    b.Name = sqlDataReader.GetString(1);
                    b.Author = sqlDataReader.GetString(2);
                    b.Year = sqlDataReader.GetInt32(3);


                    books.Add(b);
                }

                return books;
            }
        }
        public int InsertBook(Book b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO Books VALUES('"
                    + b.Name + "', '" + b.Author + "', '" + b.Year + "')";

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
