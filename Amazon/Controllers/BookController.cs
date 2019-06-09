﻿using Amazon.Models;
using Amazon.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Amazon.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int PageSize = 4;  //CUANTOS PRODUCTOS A MOSTRAR POR PAGINA
        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        // public ViewResult List() => View(repository.Books);
        public ViewResult List(string category, int bookPage = 1)
        {
            var bookListViewModel = new BooksListViewModel
            {
                Books = repository.Books.Where(p => category == null || p.Category == category)
            .OrderBy(p => p.Price)
            .Skip((bookPage - 1) * PageSize)
            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = bookPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Books.Count()
                },
                CurrentCategory = category
            };
            return View(bookListViewModel);
        }
    }
}