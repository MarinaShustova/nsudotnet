using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewWorkersDB.Models;

namespace NewWorkersDB.Pages.Workers
{
    public class IndexModel : PageModel
    {
        private readonly NewWorkersDB.Models.Lab4Context _context;

        public IndexModel(NewWorkersDB.Models.Lab4Context context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get;set; }

        public async Task OnGetAsync()
        {
            Worker = await _context.Worker.ToListAsync();
        }
    }
}
