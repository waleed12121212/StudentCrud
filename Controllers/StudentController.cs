using Microsoft.AspNetCore.Mvc;
using StudentCrud.Data;
using StudentCrud.Models;
using StudentCrud.Data;
namespace StudentCrud.Controllers
{
    public class StudentController : Controller
    {
        StudentDbContext context = new StudentDbContext();
        public IActionResult Index( )
        {
            var students = context.Students.ToList();
            return View("Index" , students);
        }
        public IActionResult Details(int id)
        {
            var student = context.Students.Find(id);
            return View("Details" , student);
        }
        public IActionResult Create( )
        {
            return View("Create");
        }
        public IActionResult Store(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();

            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var student = context.Students.Find(id);
            return View("Edit" , student);
        }
        public IActionResult Update(Student student)
        {
            var result = context.Students.Find(student.Id);
            // context.Students.Update(student);
            result.Name = student.Name;
            result.Age = student.Age;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
