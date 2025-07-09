using KutuphaneWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace KutuphaneWeb.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _repository = new BookRepository();

        public IActionResult Index()
        {
            var books = _repository.GetAllBooks();
            return View(books);
           
        }

[HttpGet]
public IActionResult Create()
{
    return View();
}


        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
public IActionResult Create(Book book)
{

            if (!ModelState.IsValid)
            {
                return View(book);
            }

            _repository.AddBook(book);
            return RedirectToAction("Index");
        }

[HttpGet]
public IActionResult Edit(int id)
{
    var book = _repository.GetBookById(id);
    if (book == null) return NotFound();
    return View(book); 
}

     [HttpPost, ActionName("Edit")]
public IActionResult Edit(Book book)
{
    if (!ModelState.IsValid)
    {
        return View(book);
    }
    _repository.UpdateBook(book);
    return RedirectToAction("Index");
}

        public IActionResult Delete(int id)
        {
            var book = _repository.GetBookById(id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.DeleteBook(id);
            return RedirectToAction("Index");
        }

        public IActionResult RatingBook()
        {
            var ratings = _repository.GetAllRatings(); // Bu satır, Rating verilerini getiriyor olmalı
            return View(ratings); // Views/Book/RatingBook.cshtml dosyasına model gönderiyor
        }
        public IActionResult RBook()
        {
            var books = _repository.GetReadenBooks(); // Bu satır, Readen Books verilerini getiriyor olmalı
            return View(books); // Views/Book/RBook.cshtml dosyasına model gönderiyor
        }
    }
}
