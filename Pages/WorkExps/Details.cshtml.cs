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
    public class DetailsModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public DetailsModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

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
    }
}
