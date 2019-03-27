using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    [Required]
    [Display(Name = "Sample Label")]
    public string Name { get; set; }
    public IActionResult OnGet() {
        Name = "Patate";
        return Page();
    }
}