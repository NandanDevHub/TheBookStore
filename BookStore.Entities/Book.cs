﻿using System;
namespace BookStore.Entities
{
	public class Book
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string ISBNNumber { get; set; }

		public decimal Price { get; set; }

		public string BookImage { get; set; }

		public int BookAuthorId { get; set; }

		public int BookStoreId { get; set; }

	}
}

