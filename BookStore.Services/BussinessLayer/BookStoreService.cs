using System;
using BookStore.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BookStore.Services.BussinessLayer
{
	public class BookStoreService:IBookStoreService
	{
		private string connectionString = string.Empty;

        public BookStoreService(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public int DMLTrasaction(string query)
        {
            throw new NotImplementedException();
        }

        public Book GetBookbyId(int bookId)
        {
            throw new NotImplementedException();
        }

        public Cart GetCartDetails(string query)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoriesbyBookId(int bookid)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetListofBook()
        {
            List<Book> books = new();
            using SqlConnection sqlConnection = new();
            {
                string query = "select * from [Book]";
                SqlCommand sqlCommand = new();
                using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        books.Add(new Book
                        {
                           Id = Convert.ToInt32(dataReader["Id"]),
                           Name = dataReader["Name"].ToString(),
                           Description = dataReader["Description"].ToString(),
                           ISBNNumber = dataReader["ISBNNumber"].ToString(),
                           Price = Convert.ToDecimal(dataReader["Price"]),
                           BookImage = dataReader["PictureUri"].ToString(),
                           BookAuthorId = Convert.ToInt32(dataReader["BookAuthorId"]),
                           BookStoreId = Convert.ToInt32(dataReader["BookStoreId"])
                        });
                    }
                }
                sqlConnection.Close();
            }
            return books;
        }

        public List<Cart> GetListofCart(string query)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderDetails(string query)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetailsList(string query)
        {
            throw new NotImplementedException();
        }

        public Store GetStorebyId(string query)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetStoresList(string query)
        {
            throw new NotImplementedException();
        }

        public int InsertMultipleRecord(Book book, List<BookCategory> categories)
        {
            throw new NotImplementedException();
        }
    }
}

