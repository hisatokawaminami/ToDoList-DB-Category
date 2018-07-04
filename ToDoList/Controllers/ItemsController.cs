using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class ItemController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      Item newItem = new Item(Request.Query["new-item"]);
      newItem.Save();
      List<Item> all = Item.GetAll();
      return View(all);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}
