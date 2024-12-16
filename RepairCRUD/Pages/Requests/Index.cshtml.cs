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
    public class IndexModel : PageModel
    {
        private readonly RepairCRUD.Data.RepairCRUDContext _context;

        public IndexModel(RepairCRUD.Data.RepairCRUDContext context)
        {
            _context = context;
        }

        public IList<Request> Request { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Request = await _context.Request.ToListAsync();
        }
    }
}
