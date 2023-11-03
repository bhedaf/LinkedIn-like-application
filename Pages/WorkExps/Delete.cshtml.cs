using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.WorkExps
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public DeleteModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
      public WorkExp WorkExp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.WorkExp == null)
            {
                return NotFound();
            }

            var workexp = await _context.WorkExp.FirstOrDefaultAsync(m => m.ID == id);

            if (workexp == null)
            {
                return NotFound();
            }
            else 
            {
                WorkExp = workexp;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.WorkExp == null)
            {
                return NotFound();
            }
            var workexp = await _context.WorkExp.FindAsync(id);

            if (workexp != null)
            {
                WorkExp = workexp;
                _context.WorkExp.Remove(WorkExp);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
