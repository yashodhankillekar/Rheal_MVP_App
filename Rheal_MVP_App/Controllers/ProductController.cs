using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rheal_MVP_App.Models;
using Rheal_MVP_App.BizRepositories;

namespace Rheal_MVP_App.Controllers
{
    public class ProductController : Controller
    {

        IBizRepository<Product, int> productRepo;

        public ProductController()
        {
            productRepo = new ProductBizRepository();
        }

        // GET: Product
        public ActionResult Index()
        {
            var result = productRepo.getData();
            return View(result);
        }

        public ActionResult Create()
        {
            var result = new Product();
            return View(result);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                productRepo.Create(product);
                return RedirectToAction("Index");

            }
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var result = productRepo.getData(id);

            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                productRepo.Update(id, product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            productRepo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}