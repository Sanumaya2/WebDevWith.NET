using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetStarter.Basics.DataAccess;

namespace CollegeMonitor.Pages_Sessions
{
    public class DeleteModel : PageModel
    {
        private readonly NetStarter.Basics.DataAccess.CollegeDbContext _context;

        public DeleteModel(NetStarter.Basics.DataAccess.CollegeDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Session Session { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Sessions.FirstOrDefaultAsync(m => m.id == id);

            if (session == null)
            {
                return NotFound();
            }
            else
            {
                Session = session;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var session = await _context.Sessions.FindAsync(id);
            if (session != null)
            {
                Session = session;
                _context.Sessions.Remove(Session);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}