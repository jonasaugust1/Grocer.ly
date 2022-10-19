using Grocer.ly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.ly.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Rating { get; set; }
        [BindProperty]
        public string Feedback { get; set; }
        [BindProperty]
        public List<GroceryItem> Foods { get; set; }
        public void OnGet()
        {
            Foods = Inventory.ToList();
        }
    }
}