﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Models.Extensions;
namespace Amazon.Models
{
    public class BookRepository
    {
        public static List<Book> books = new List<Book>();  //llena la lista libros
        public static IEnumerable<Book> Books    //retorna la lsita libros
        {
            get
            {
                return books;
            }
        }
        public static void AddResponse(Book book)  //agrega libros
        {
            books.Add(book);
        }

        public static List<Book> FillBooks()
        {
            if (!Books.Any())
            {
                Book book1 = new Book()
                {
                    ISBN = "123456789",
                    Author = "Giancarlo G",
                    NroPages = 260,
                    Price = 270,
                    Title = "How to Program ASP.NET MVC",
                    LevelStock = LevelStock.SoldOut
                };
                Book book2 = new Book()
                {
                    ISBN = "521648597",
                    Author = "Giancarlo G",
                    NroPages = 3200,
                    Price = 3000,
                    Title = "How to Program C#",
                    LevelStock = LevelStock.InStock

                };
                Book book3 = new Book()
                {
                    ISBN = "521648597",
                    Author = "Giancarlo G",
                    NroPages = 3200,
                    Price = 3000,
                    Title = "How to Program C#123",
                    LevelStock = LevelStock.SoldOut
                };
                Book book4 = new Book()
                {
                    ISBN = "521648597",
                    Author = "Giancarlo G",
                    NroPages = 3200,
                    Price = 3000,
                    Title = "How to Program C#456",
                    LevelStock = LevelStock.SoldOut
                };
                books.Add(book1);
                books.Add(book2);
                books.Add(book3);
                books.Add(book4);
                books.Add(null);
            }
           
            return books;
        }
        public static decimal TotalPrice()
        {

            return books.TotalPriceExtension();
            
        }
        public static IEnumerable<Book> FilterBookByPagesRatherThan(int nroPages)
        {
            return books.FilterByNroPagesGreaterThan(nroPages);
        }
    }
}
