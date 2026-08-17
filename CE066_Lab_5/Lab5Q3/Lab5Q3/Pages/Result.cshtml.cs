using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab5Q3.Pages
{
    public class ResultModel : PageModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }

        public void OnGet()
        {
            Name = HttpContext.Session.GetString("Name");
            Email = HttpContext.Session.GetString("Email");
            ContactNo = HttpContext.Session.GetString("ContactNo");
            Gender = HttpContext.Session.GetString("Gender");
        }
    }
}