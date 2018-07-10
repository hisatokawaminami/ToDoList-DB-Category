using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class ItemController : Controller
  {
    [HttpPost("/items")]
    public ActionResult CollectInfo()
    {
      Item newItem = new Item(Request.Form["new-item"], Request.Form["new-date"]);
      newItem.Save();
      // List<Item> all = Item.GetAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/items")]
    public ActionResult Index()
    {
      // List<Item> all = Item.GetAll();
      return View(Item.GetAll());
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

  }
}
