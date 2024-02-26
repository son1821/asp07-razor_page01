using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp07.Pages
{
    public class FirstPageModel : PageModel
    {
        public string title { set; get; } = "Day la trang razor page dau tien cua Son";

        public string Welcome(string name)
        {
            return $"Chao mung {name} den voi website";
        }

        public void OnGet()
        {
            Console.WriteLine("Truy van Get");
            ViewData["mydata"] = "Son hoc ASP.NET Core 2024";
        }
        //Get - ?handler = Abc 
        public void OnGetAbc()
        {
            Console.WriteLine("Truy van Get");
            ViewData["mydata"] = "Son hoc ASP.NET Core 2024 Abc";
        }
    }
}
