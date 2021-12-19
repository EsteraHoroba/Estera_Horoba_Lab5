using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Estera_Horoba_Lab5.Data;
using Estera_Horoba_Lab5.Models;

namespace Estera_Horoba_Lab5.Pages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Estera_Horoba_Lab5.Data.Estera_Horoba_Lab5Context _context;

        public IndexModel(Estera_Horoba_Lab5.Data.Estera_Horoba_Lab5Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
             .ToListAsync();
        }
    }
}
