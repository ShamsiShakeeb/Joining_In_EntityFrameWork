using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joining_In_EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joining_In_EF.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JoinTestController : Controller
    {
        private readonly DatabaseContext _context;

        public JoinTestController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/JoinTest
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            int uid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            var data = await _context.Student_And_Subject.Where(x => x.Student_ID == uid).
             Select(z => new { z.Student.Name, z.Subject.Subject_ID, z.Subject.Title, z.Subject.Description }).ToListAsync();

            return Json(data);

        }

        // GET: api/JoinTest/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/JoinTest
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/JoinTest/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
