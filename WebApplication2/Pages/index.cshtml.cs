using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.models;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        public List<Users> Users { get; set; }
     
        private readonly UserContext _context;

        public IndexModel(UserContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            Users = _context.User.AsNoTracking().ToList();
        }
    }
}
