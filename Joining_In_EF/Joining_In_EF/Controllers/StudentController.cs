using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joining_In_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joining_In_EF.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseContext _context;

        public StudentController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> MySubjectList()
        {
            if (HttpContext.Session.GetString("UserID") == null)
            {
                return BadRequest();
            }
            else if (HttpContext.Session.GetString("UserID").Equals(""))
            {
                return BadRequest();
            }

            int uid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));

            var data = await _context.Student_And_Subject.Where(x => x.Student_ID == uid).
                Select(y => y.Subject_ID).ToListAsync();

              List<Subject> sub = new List<Subject>();

              foreach(var subjects in data)
              {
                  var value = await _context.subject.Where(x => x.Subject_ID == subjects)
                      .FirstOrDefaultAsync<Subject>();
                  sub.Add(value);
              }

            return View(sub);
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("UserID") == null)
            {
                return BadRequest();
            }
            else if (HttpContext.Session.GetString("UserID").Equals(""))
            {
                return BadRequest();
            }

            var subject = await _context.subject.ToListAsync();

            return View(subject);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {

            if (ModelState.IsValid)
            {
                _context.student.Add(student);
                await _context.SaveChangesAsync();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Something Went Hrror!!!");
            }

            return View(student);

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(Student student)
        {

            var data = await _context.student.Where((x => x.Name == student.Name && x.Phone == student.Phone))
                .FirstOrDefaultAsync<Student>();

            if (data == null)
            {
                ModelState.AddModelError(string.Empty, "Login Failed");
               /// return BadRequest();
            }
            else
            {
                HttpContext.Session.SetString("UserID", data.Student_ID.ToString());
                return Redirect("~/Student/Index");
            }
            return View(student);

        }

        public async Task<ActionResult> TakeCourse()
        {
            if (!HttpContext.Request.Query.ContainsKey("a"))
            {
                return BadRequest();
            }

            int Subject_ID = Convert.ToInt32(HttpContext.Request.Query["a"]);
            String User_Id = HttpContext.Session.GetString("UserID");
          

            if (User_Id == null)
            {
                return BadRequest();
            }
            else if (User_Id.Equals(""))
            {
                return BadRequest();
            }
            int uid = Convert.ToInt32(User_Id);
            var data = await _context.Student_And_Subject.Where((x => x.Subject_ID == Subject_ID && x.Student_ID == uid)).
             FirstOrDefaultAsync<Student_And_Subject>();
           
            if(data!=null)
            {
                ViewBag.Message = "This Subject is Already Taken";
                return Redirect("~/Student/Index");
            }
            else
            {
              
                var value = new Student_And_Subject()
                {
                    Student_ID = uid,
                    Subject_ID=Subject_ID,

                  //  Student=await _context.student.Where(x=> x.Student_ID==uid).
                  //   FirstOrDefaultAsync<Student>(),

                  //  Subject=await _context.subject.Where(x=> x.Subject_ID==Subject_ID).
                  //  FirstOrDefaultAsync<Subject>(),

                };

                _context.Student_And_Subject.Add(value);
                await _context.SaveChangesAsync();
                ViewBag.Message = "New Course Added";
                return Redirect("~/Student/Index");
            }
        }


    }
}