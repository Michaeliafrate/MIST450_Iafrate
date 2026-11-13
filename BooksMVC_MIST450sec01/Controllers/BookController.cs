using BooksMVC_MIST450sec01.Data;
using BooksMVC_MIST450sec01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksMVC_MIST450sec01.Controllers
{
    public class BookController : Controller
    {
        private BooksDbContext _context;


        public BookController(BooksDbContext context ) //dependency injection
        {
            _context = context;//context exists only within the body of this method

        }




        public IActionResult Index()
        {
            var bookList = _context.Books.ToList();//fetches a list of books from the book table

            return View(bookList);//passes the book list to the view
        }


        [HttpGet]
        public IActionResult Create()//create a new book record
        {
            return View();//returns a blank form to the user
        }


        [HttpPost]
        public IActionResult Create(Book bookObj)
        {
            _context.Books.Add(bookObj);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var retrievedBook = _context.Books.Find(id);//find the book which has the id that was passed in and save it in the retrievedBook var


            return View(retrievedBook);
        }


        public IActionResult Edit(int id)
        {
            //talk to the database and fetch the book that the user would like to edit
            var retrievedBook = _context.Books.Find(id);

            return View(retrievedBook);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("BookId, Description, Title, Author, DatePublished, Price, Genre")] Book updatedBook)
        {
            //talk to the database and save the data that the user has provided
            if (ModelState.IsValid)
            {
                _context.Books.Update(updatedBook);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
