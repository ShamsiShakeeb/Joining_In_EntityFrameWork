using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joining_In_EF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joining_In_EF.Controllers
{
    public class SubjectController : Controller
    {

        private readonly DatabaseContext _context;

        public SubjectController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.subject.ToListAsync()); ;
        }

        public IActionResult Create_Subject()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create_Subject(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _context.subject.Add(subject);
                await _context.SaveChangesAsync();
                return Redirect("~/Subject/Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Something Went Hrror!!!");
                return View(subject);
            }
        }


    }
}