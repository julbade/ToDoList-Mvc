using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
public class ItemsController : Controller
{

  [HttpGet("/items")]
  public ActionResult Index()
  {
    List<Item> allItems = Item.GetAll();
    return View(allItems);
  }

  [HttpGet("/items/new")]
  public ActionResult CreateForm()
  {
      return View();
  }

  [HttpPost("/items")]
  public ActionResult Create()
  {
      Item newItem = new Item(Request.Form["new-item"]);
      List<Item> allItems = Item.GetAll();
      newItem.Save();
      return View("Index", allItems);
  }
  [HttpGet("/items/{id}")]
  public ActionResult Details(int id)
  {
     Item item = Item.Find(id);
     return View(item);
 }
 [HttpGet("items/delete")]
 public ActionResult DeleteAll()
 {
  Item.DeleteAll();
  return View();
 }
 }
}
