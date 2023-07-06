using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace NewShop
{
    //[ApiController]
    //[Route("api/[controller]")]
    //public class StorageController: Controller
    //{
    //    private readonly IWebHostEnvironment environment;
    //    public StorageController(IWebHostEnvironment environment)
    //    {
    //        this.environment = environment;
    //    }

    //    [HttpGet("/download/{filename}")]
    //    public FileStreamResult GetFile([FromRoute] string fileName)
    //    {
    //        var physicalPath = $"D:/Temp/Storage/gameshop/{fileName}";
    //        var pdfBytes = System.IO.File.ReadAllBytes(physicalPath);
    //        var ms = new MemoryStream(pdfBytes);
    //        return new FileStreamResult(ms, "application/octet-stream");
    //    }
    //}

    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : Controller
    {
        private readonly IWebHostEnvironment environment;
        public DownloadController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpGet("[action]")]
        public IActionResult DownloadFile(string fileName, string extention)
        {
            try
            {
                Console.WriteLine(fileName);
                Console.WriteLine(extention);
                var physicalPath = $"D:/Temp/Storage/gameshop/{fileName}.{extention}";

                var stream = new FileStream(physicalPath, FileMode.Open);

                var result = new FileStreamResult(stream, "text/plain");
                result.FileDownloadName = fileName;
                return File(stream, "application/octet-stream", $"{fileName}.{extention}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);   
            }
            
        }
    }
}
