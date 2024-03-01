using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Day3.Models;
using Day3.ViewModels;

namespace Day3.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplictionDbContext _context;
        // GET: Books
        public BooksController()
        {
            _context = new ApplictionDbContext();
        }
        public ActionResult Index()
        {
            var book = _context.BOOks.Include(m => m.Category).ToList();
            return View(book);
        }

        public ActionResult Create()
        {
            var viewmodel = new BookFormViewmodel
            {
                categories = _context.Categories.Where(m => m.IsActine).ToList()
            };
            return View("Bookform", viewmodel);
        }
        public ActionResult Edit(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var book = _context.BOOks.Find(id);
            if (book == null)
                return HttpNotFound();
            var viewModel = new BookFormViewmodel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                categories = _context.Categories.Where(c => c.IsActine).ToList()
            };
            return View("Bookform", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(BookFormViewmodel model)
        {
            if (!ModelState.IsValid)
            {
                model.categories = _context.Categories.Where(m => m.IsActine).ToList();

                return View("Bookform", model);
            }
            if (model.Id == 0)
            {
                var book = new Book()
                {
                    Title = model.Title,
                    Author = model.Author,
                    CategoryId = model.CategoryId,
             
                };

                _context.BOOks.Add(book);
                TempData["successData"] = "successfully";


            }
            else
            {
                var book = _context.BOOks.Find(model.Id);
                if (book == null)
                    return HttpNotFound();

                book.Title = model.Title;
                book.Author = model.Author;
                book.CategoryId = model.CategoryId;
            }
            TempData["successData"] = "successfully";
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public void createSelectList(int selectId = 1)
        {
     
            List<Category> categories = _context.Categories.ToList();
            SelectList listItems = new SelectList(categories, "Id", "Name", selectId);
            ViewBag.CategoryList = listItems;
        }

        //GET
        //POST
        public ActionResult Delete(int? Id)
        {
            var book = _context.BOOks.Find(Id);
            if (book == null)
            {
                return HttpNotFound();
            }
            _context.BOOks.Remove(book);
            _context.SaveChanges();
            TempData["successData"] = "successfully";

            return RedirectToAction("Index");
        }
    }
}
