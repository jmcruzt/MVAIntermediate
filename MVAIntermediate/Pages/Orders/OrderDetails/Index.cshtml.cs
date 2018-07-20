using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVAIntermediate.Data;
using MVAIntermediate.Models;

namespace MVAIntermediate.Pages.Orders.OrderDetails
{
    public class IndexModel : PageModel
    {
        private readonly MVAIntermediate.Data.ApplicationDbContext _context;

        public IndexModel(MVAIntermediate.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.OrderDetails> OrderDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetails = await (_context.OrderDetails.Where(s => s.OrderNo == id).ToListAsync<Models.OrderDetails>());
            
            if (OrderDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}