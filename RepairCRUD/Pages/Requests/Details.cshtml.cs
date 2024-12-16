using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RepairCRUD.Data;
using RepairCRUD.models;

namespace RepairCRUD.Pages.Requests
{
    public class DetailsModel : PageModel
    {
        private readonly RepairCRUD.Data.RepairCRUDContext _context;

        public DetailsModel(RepairCRUD.Data.RepairCRUDContext context)
        {
            _context = context;
        }

        public Request Request { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request.FirstOrDefaultAsync(m => m.RequestId == id);
            if (request == null)
            {
                return NotFound();
            }
            else
            {
                Request = request;
            }
            return Page();
        }
    }
}
