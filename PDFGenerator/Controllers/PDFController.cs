using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDFGenerator.Services;

namespace PDFGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDFController : ControllerBase
    {
        private readonly IPDFService _pdfService;

        public PDFController(IPDFService pdfService)
        {
            _pdfService = pdfService;
        }

        [HttpPost("{name}")]
        public async Task<IActionResult> CreatePDFAsync(string name)
        {
            try
            {
                var result = await _pdfService.CreatePDFAsync(name);
                return File(result, "application/pdf", "yourname.pdf");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
