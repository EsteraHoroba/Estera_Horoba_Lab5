using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Estera_Horoba_Lab5.Data;
using Estera_Horoba_Lab5.Models;

namespace Estera_Horoba_Lab5.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Estera_Horoba_Lab5.Data.Estera_Horoba_Lab5Context _context;

        public CreateModel(Estera_Horoba_Lab5.Data.Estera_Horoba_Lab5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
