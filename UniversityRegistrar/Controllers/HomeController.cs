using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
    public class HomeController : Controller
    {

      private readonly UniversityRegistrarContext _db;

      public HomeController(UniversityRegistrarContext db)
      {
        _db = db;
      }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Student[] stus = _db.Students.ToArray();
      Course[] courses = _db.Courses.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("students", stus);
      model.Add("courses", courses);
      return View(model);
    }      

    }
}