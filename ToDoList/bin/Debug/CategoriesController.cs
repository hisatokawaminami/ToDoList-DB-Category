using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class CategoryController : Controller
  {
    [HttpGet("/categories/new")]
    public ActionResult CategoryForm()
    {
      return View();
    }

    [HttpPost("/categories")]
    public ActionResult CollectCategory()
    {
      Category newCategory = new Category(Request.Form["new-category"]);
      newCategory.Save();
      List<Category> allCategories = Category.GetAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      return View(Category.GetAll());
    }
  }
}
