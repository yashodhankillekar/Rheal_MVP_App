using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rheal_MVP_App.Models;
using Rheal_MVP_App.BizRepositories;

namespace Rheal_MVP_App.Controllers
{
    public class CategoryController : Controller
    {
        IBizRepository<Category, int> catRepo;

        public CategoryController()
        {
            catRepo = new CategoryBizRepository();
        }
        // GET: Category
        public ActionResult Index()
        {
            var result = catRepo.getData();
            return View(result);
        }

        public ActionResult Create()
        {
            var result = new Category();
            // return a view that will show empty
            // category information
            return View(result);
        }
        
        [HttpPost]
        public ActionResult Create(Category data)
        {
            // Validate the posted model with ModelState property of the Controller base class 
            // This validations will be executed based on Validation rules applied on
            // Model classes using Data Annotations
            if (ModelState.IsValid)
            {
                // then only save the data
                data = catRepo.Create(data);
                // Redirect to the Index Action Method
                return RedirectToAction("Index");
            }
            // if the model is invalid stay on the same veiw and display
            // Validation errors
            return View(data);
        }


        public ActionResult Edit(int id)
        {
            // search record
            var result = catRepo.getData(id);
            // return view showing the searched record
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(int id, Category data)
        {
            if (ModelState.IsValid)
            {
                catRepo.Update(id, data);
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var result = catRepo.Delete(id);
            return RedirectToAction("Index");
        }


    }
}