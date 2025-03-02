using System;
using BookStore.Entities;

namespace BookStore.Services
{
	public interface IBookStoreService
	{
		public List<Book> GetListofBook();

		public List<Category> GetCategoriesbyBookId(int bookid);

		public OrderDetail GetOrderDetails(string query);

		public Cart GetCartDetails(string query);

		public List<Cart> GetListofCart(string query);

		public List<OrderDetail> GetOrderDetailsList(string query);

		public int InsertMultipleRecord(Book book, List<BookCategory> categories);

		public Store GetStorebyId(string query);

		public List<Store> GetStoresList(string query);

		public Book GetBookbyId(int bookId);

		public int DMLTrasaction(string query);
	}
}

