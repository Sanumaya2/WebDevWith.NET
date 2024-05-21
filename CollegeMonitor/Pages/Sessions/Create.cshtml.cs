using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace CollegeMonitor.Pages_Sessions
{
    public class CreateModel : PageModel
    {
        private readonly CollegeDbContext _context;

        public CreateModel(CollegeDbContext context)
        {
            _context = context;
        }

          public async Task<IActionResult> OnGetAsync()
        {
            // Courses = _context.Courses
            // .Select(x=>new SelectListItem { Text=x.Name, Value=x.Id.ToString()})
            // .ToList();
              HttpClient http=new HttpClient();
            Sessions = await http.GetFromJsonAsync<List<Session>>("http://localhost:5017/sessions");
            return Page();
        }

        [BindProperty]
        public Session Session { get; set; } = default!;
         public List<Session> Sessions { get; set; }
        public List<SelectListItem> Courses{get ; set ;}
       

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sessions.Add(Session);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
