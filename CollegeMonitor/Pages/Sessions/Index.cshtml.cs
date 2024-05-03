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
    public class IndexModel : PageModel
    {
        private readonly NetStarter.Basics.DataAccess.CollegeDbContext _context;

        public IndexModel(NetStarter.Basics.DataAccess.CollegeDbContext context)
        {
            _context = context;
        }

        public IList<Session> Session { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Session = await _context.Sessions.Include(x => x.Course).ToListAsync();
        }
    }
}
