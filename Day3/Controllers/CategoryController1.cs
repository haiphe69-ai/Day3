using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3.Models;
using AspNetCoreGeneratedDocument;

namespace Day3.Controllers
{
    public class CategoryController1 : Controller
    {
        private static List<Models.Category_Id_Name_> categories = new List<Models.Category_Id_Name_>
        {
            new Models.Category_Id_Name_ { Id = 1, Name = "Electronics" },
            new Models.Category_Id_Name_ { Id = 2, Name = "Books" },
            new Models.Category_Id_Name_ { Id = 3, Name = "Clothing" }
        };
        // GET: CategoryController1
        public ActionResult Index()
        {

            return View(categories);
        }

        // GET: CategoryController1/Details/5
        public ActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Category_Id_Name_ category)
        {

            if (ModelState.IsValid)
            {
                int newId = categories.Any() ? categories.Max(c => c.Id) + 1 : 1;
                categories.Add(category);
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        // GET: CategoryController1/Edit/5
        public ActionResult Edit([FromRoute] int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: CategoryController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category_Id_Name_ category)

        {
            var existingCategory = categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                existingCategory.Name = category.Name;
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        // GET: CategoryController1/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: CategoryController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            categories.Remove(category);
            return RedirectToAction(nameof(Index));

        }
    }
}
