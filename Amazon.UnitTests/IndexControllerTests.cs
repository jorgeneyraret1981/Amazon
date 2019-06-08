using Amazon.Controllers;
using Amazon.Models;
using Amazon.UnitTests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace Amazon.Test
{
    public class IndexControllerTests
    {
        class ModelCompleteFakeRepository //: IRepository
        {
            /*  public IEnumerable<Book> Books => new List<Book> {
                     new Book() { Title = "Book1", Price = 200, NroPages = 250 },
                     new Book() { Title = "Book2", Price = 300, NroPages = 180 },
                     new Book() { Title = "Book3", Price = 150, NroPages = 350 },
                     new Book() { Title = "Book4", Price = 300, NroPages = 400 }};
              public void AddBook(Book p)
              { //no requerido para el test } }
              }
              */
            public IEnumerable<Book> Books { set; get; }

            public void AddBook(Book p)
            {
                //no requerido para el test
            }
        }
      //  [Theory]
        // [InlineData(250, 180, 350, 400)]
        //[InlineData(320, 310, 500, 800)]
       // [ClassData(typeof(BookTestData))]
        //public void IndexActionModelIsComplete(Book[] books)
        //{
            // Arrange
            //  var controller = new HomeController();
            //  controller.repository = new ModelCompleteFakeRepository
            //  {
            //      Books = books
            //  };
            /* var mock = new Mock<IRepository>();
             mock.SetupGet(m => m.Books).Returns(books);
             var controller = new HomeController { repository = mock.Object };
             // Act
             var model = (controller.Index() as ViewResult)?.ViewData.Model
             as IEnumerable<Book>;
             Assert.Equal(controller.repository.Books, model,
                            Comparer.Get<Book>((p1, p2) => p1.Title == p2.Title && p1.NroPages == p2.NroPages));
             // Assert Assert.Equal(controller.repository.Books, model, Comparer.Get<Book>((p1, p2) => p1.Title == p2.Title && p1.NroPages == p2.NroPages));
         }
         /*       public void IndexActionModelIsComplete(decimal nroPages1, decimal nroPages2, decimal nroPages3, decimal nroPages4)
                {
                    // Arrange
                    var controller = new HomeController();
                    controller.repository = new ModelCompleteFakeRepository {
                        Books = new List<Book> {
                        new Book { Title = "B1", Price = nroPages1 },
                        new Book { Title = "B2", Price = nroPages2 },
                        new Book { Title = "B3", Price = nroPages3 },
                        new Book { Title = "B4", Price = nroPages4 },
                     }
                 };
                    // Act
                    var model = (controller.Index() as ViewResult)?.ViewData.Model
                    as IEnumerable<Book>;
                    // Assert
                    Assert.Equal((controller.repository.Books as List<Book>).Count,
                    (model as List<Book>).Count);
                }
                */

            /* [Fact]
             public void IndexActionModelIsComplete()
             {
                 // Arrange
                 var controller = new HomeController();
                 controller.repository = new ModelCompleteFakeRepository();
                 // Act 
                 var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;
                 // Assert 
                 var responsesCount = ((List<Book>)controller.repository.Books).Count;
                 var modelCount = ((List<Book>)model).Count;
                 Assert.Equal(responsesCount, modelCount);
             }
             */
        //}
        class ModelCompleteFakeRepositoryPagesGreaterThan300 //: IRepository
        {
            public IEnumerable<Book> Books => new List<Book> {
                new Book() { Title = "Book1", Price = 200, NroPages = 320 },
                new Book() { Title = "Book2", Price = 280, NroPages = 310 },
                new Book() { Title = "Book3", Price = 150, NroPages = 500 },
                new Book() { Title = "Book4", Price = 300, NroPages = 800 }};
            public void AddBook(Book p)
            { }
        }
        [Fact]
        public void IndexActionModelIsCompletePagesGreaterThan300()
        { // Arrange
          /*  var controller = new HomeController();
            controller.repository = new ModelCompleteFakeRepositoryPagesGreaterThan300();
            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;
            // Assert
            Assert.Equal((controller.repository.Books as List<Book>).Count,
                (model as List<Book>).Count); }
                */
        }
    }

}