using Microsoft.AspNetCore.Mvc.RazorPages;
using NetStarter.Basics.DataAccess;

public class CoursesModel : PageModel
{
    public List<Course> Courses {get ; set ;}
    public async Task OnGet()
    {
        // CollegeDbContext db = new();
        // Courses = db.Courses.ToList();
    
    // Consuming REST API with httpclient
    HttpClient http = new HttpClient();
    Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5017/courses");

    }
}