using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataRepository
    {
        public List<Book> GetAllBooks()
        {
            List<Book> lista = new List<Book>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Books";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Book b = new Book();
                    b.Id = sqlDataReader.GetInt32(0);
                    b.Name = sqlDataReader.GetString(1);
                    b.Author = sqlDataReader.GetString(2);
                    b.Year = sqlDataReader.GetInt32(3);

                    lista.Add(b);
                }
            }

            return lista;
        }
        public int InsertBook(Book b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Books VALUES ('{0}', '{1}', {2})",
                        b.Name, b.Author, b.Year);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
