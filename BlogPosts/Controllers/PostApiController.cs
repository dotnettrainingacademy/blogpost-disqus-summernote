using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPosts.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPosts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostApiController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public PostApiController(ApplicationDbContext _db)
        {
            db = _db;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var postTitle = db.BlogPosts.Where(p => p.PostName.Contains(term))
                                            .Select(p => p.PostName).ToList();
                return Ok(postTitle);
            }
            catch 
            {
                return BadRequest();
            }
        }
    }
}