using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
