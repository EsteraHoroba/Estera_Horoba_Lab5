﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Estera_Horoba_Lab5.Data.Estera_Horoba_Lab5Context _context;

        public DetailsModel(Estera_Horoba_Lab5.Data.Estera_Horoba_Lab5Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
