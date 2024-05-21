using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EditCourseModel : PageModel
{
    [BindProperty]
    public Course Course { get; set; }
       public List<Course> Courses { get; set; }
    
    public async Task OnGetAsync(int id)
    {
        // CollegeDbContext db = new();
        // Course = db.Courses.Find(id);
         HttpClient http=new HttpClient();
        //Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5017/courses/{id}");
        Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5017/courses");
        
    }

    public IActionResult OnPost()
    {
        CollegeDbContext db = new();
        db.Courses.Update(Course);
        db.SaveChanges();
      

        return RedirectToPage("Courses");
    }
}