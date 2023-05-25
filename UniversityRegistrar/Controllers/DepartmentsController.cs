using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public DepartmentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Department> model = _db.Departments.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
   
    public ActionResult Edit(int id)
    {
      Department dept = _db.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
      return View(dept);
    }

    [HttpPost]
    public ActionResult Edit(Department department)
    {
      _db.Departments.Update(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Department thisDepartment = _db.Departments
                                     .Include(department => department.Courses)
                                     .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);

    }


  }
}