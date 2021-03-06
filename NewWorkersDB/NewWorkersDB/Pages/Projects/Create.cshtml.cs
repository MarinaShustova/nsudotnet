﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewWorkersDB.Models;

namespace NewWorkersDB.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly NewWorkersDB.Models.Lab4Context _context;

        public CreateModel(NewWorkersDB.Models.Lab4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["WorkerID"] = new SelectList(_context.Worker, "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}