using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class DeleteCourseModel : PageModel
{
    private object?[]? id;

    [BindProperty]
    public Course Course { get; set; }
    public List<Course> Courses { get; set; }
    public async Task OnGetAsync(int id)
    {
        // CollegeDbContext db = new();
        // Course = db.Courses.Find(id);
        HttpClient http = new HttpClient();
        Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5017/courses");
    }

    public IActionResult OnPost()
    {
        CollegeDbContext db = new();
        var course = db.Courses.Find(id);
        db.Courses.Remove(Course);
        db.SaveChanges();

        return RedirectToPage("Courses");
    }
}