using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewWorkersDB.Models;

namespace NewWorkersDB.Pages.Leaderboard
{
    public class IndexModel : PageModel
    {
        private readonly Lab4Context _context;

        public IndexModel(Lab4Context context) {
            _context = context;
        }

        public List<Worker> Worker { get; set; }
        public IList<Project> Projects { get; set; }
        public async Task OnGetAsync() {

            IQueryable<Worker> WorkerPremium = from s in _context.Worker.Include("Projects")
                                              
                                               //join p in _context.Project on s.FullName equals p.Worker.FullName
                                               //group s by s.Projects.
                                            select s;
            WorkerPremium = WorkerPremium.OrderByDescending(s => s.Projects.Sum(o => o.Premium));

            Worker = await WorkerPremium.ToListAsync();
        }
    }
}
