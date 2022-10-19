using Grocer.ly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grocer.ly.Pages
{
    public class DeaModel : PageModel
    {
        public List<GroceryItem> Foods = Inventory.ToList();
        public GroceryItem CurrentFood { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            CurrentFood = Foods.Find(food => food.Name.ToLower() == name.ToLower());

            if(CurrentFood == null) return NotFound();

            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} {name}");
            }

            return Page();

        }
    }
}
