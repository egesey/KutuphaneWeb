using KutuphaneWeb.Models;
using MySqlConnector;

namespace KutuphaneWeb.Models
{
    public class BookRepository
    {
        private readonly string _connectionString = "Server=127.0.0.1;Port=3306;Database=LibaryDB;User ID=libraryuser;Password=6161;";

        public void AddBook(Book book)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "INSERT INTO Book (Name, Author, Year, Price) VALUES (@name, @author, @year, @price)",
                    connection);
                command.Parameters.AddWithValue("@name", book.Name);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@year", book.Year);
                command.Parameters.AddWithValue("@price", book.Price);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateBook(Book book)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "UPDATE Book SET Name = @name, Author = @author, Year = @year, Price = @price WHERE BId = @id",
                    connection);
                command.Parameters.AddWithValue("@name", book.Name);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@year", book.Year);
                command.Parameters.AddWithValue("@price", book.Price);
                command.Parameters.AddWithValue("@id", book.BId);
                command.ExecuteNonQuery();
            }
        }

        public Book? GetBookById(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT BId, Name, Author, Year, Price FROM Book WHERE BId = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Book
                        {
                            BId = reader.GetInt32("BId"),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString("Name"),
                            Author = reader.IsDBNull(reader.GetOrdinal("Author")) ? "" : reader.GetString("Author"),
                            Year = reader.GetInt32("Year"),
                            Price = reader.GetDecimal("Price")
                        };
                    }
                }
            }
            return null;
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT BId, Name, Author, Year, Price FROM Book", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            BId = reader.GetInt32("BId"),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString("Name"),
                            Author = reader.IsDBNull(reader.GetOrdinal("Author")) ? "" : reader.GetString("Author"),
                            Year = reader.GetInt32("Year"),
                            Price = reader.GetDecimal("Price")
                        });
                    }
                }
            }
            return books;
        }

        public void DeleteBook(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM Book WHERE BId = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Rating> GetAllRatings()
        {
            var ratings = new List<Rating>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT RaId, Name, Ratings FROM Rating", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ratings.Add(new Rating
                        {
                            RaId = reader.GetInt32("RaId"),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString("Name"),
                            Ratings = reader.GetFloat("Ratings")
                        });
                    }
                }
            }

            return ratings;
        }

        public List<ReadenBooks> GetReadenBooks()
        {
            var readenBooks = new List<ReadenBooks>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT RId, Name FROM ReadenBooks", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        readenBooks.Add(new ReadenBooks
                        {
                            RId = reader.GetInt32("RId"),
                            Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "" : reader.GetString("Name")
                        });
                    }
                }
            }

            return readenBooks;
        }
    }
    
}