﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dumitrache_Dan_Lab2.Data;
using Dumitrache_Dan_Lab2.Models;

namespace Dumitrache_Dan_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Dumitrache_Dan_Lab2.Data.Dumitrache_Dan_Lab2Context _context;

        public CreateModel(Dumitrache_Dan_Lab2.Data.Dumitrache_Dan_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
