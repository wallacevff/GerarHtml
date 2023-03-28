using GerarHtml.Models;
using GerarHtml.Services.DinkToPdf;
using GerarHtml.Services.Template;
using Microsoft.AspNetCore.Mvc;


namespace GerarHtml.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateController : ControllerBase
    {

        internal readonly ITemplateService _templateService;
        internal readonly IDinkToPdfService _dinkToPdfService;

        public GenerateController(ITemplateService templateService, IDinkToPdfService dinkToPdfService)
        {
            _templateService = templateService;
            _dinkToPdfService = dinkToPdfService;
        }
        [HttpGet("html")]
        //[Produces("text/html")]
        public async Task<ActionResult> GetHtml()
        {
            var result = await _templateService.Parse(new ViewModel("TesteIReport", "Wallace Vidal"));
            return new ContentResult()
            {
                ContentType = "text/html",
                Content = result,
            };

        }

        [HttpGet("pdf")]
        //[Produces("text/html")]
        public async Task<ActionResult> GetPdf()
        {
            var result = await _templateService.Parse(new ViewModel("TesteIReport", "Wallace Vidal"));
            return new FileStreamResult(new MemoryStream(
                _dinkToPdfService.ConvertToPdf(result)), 
                "application/pdf");
        }

    }
}
