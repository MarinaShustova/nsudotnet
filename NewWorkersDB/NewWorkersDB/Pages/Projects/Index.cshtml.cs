using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewWorkersDB.Models;

namespace NewWorkersDB.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly NewWorkersDB.Models.Lab4Context _context;

        public IndexModel(NewWorkersDB.Models.Lab4Context context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Project
                .Include(p => p.Worker).ToListAsync();
        }
    }
}
