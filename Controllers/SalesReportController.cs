using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using salesreportapi.Dal;
using salesreportapi.Models;

namespace salesreportapi.Controllers
{
  
    
        [Route("api/[controller]")]
        [ApiController]
        public class SalesReportController : ControllerBase
        {

            private readonly SalesDbcontext _context;

            public SalesReportController(SalesDbcontext context)
            {
                _context = context;
            }



            [HttpGet("GetSalesReport")]
            public async Task<ActionResult<IEnumerable<Sales>>> GetSalesReport()
            {
                var salesReport = await _context.Sales
                    .Include(s => s.SaleLines)
                    .ToListAsync();

                return Ok(salesReport);
            }
        }
    }

    
