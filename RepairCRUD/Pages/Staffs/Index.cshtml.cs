﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepairCRUD.Data;
using RepairCRUD.models;

namespace RepairCRUD.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly RepairCRUD.Data.RepairCRUDContext _context;

        public IndexModel(RepairCRUD.Data.RepairCRUDContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
