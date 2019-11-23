﻿namespace House2Invest.Pages.AppPerfil
{
    using House2Invest.Data;
    using House2Invest.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System;
    using System.Runtime.CompilerServices;

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult OnGet()
        {
            return this.RedirectToPage("./Index");
        }

        public IActionResult OnPostAsync()
        {
            return this.RedirectToPage("./Index");
        }
    }
}

