using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarkusApi.Controllers
{
    [Route("api/[controller]")]
    // [ApiController]
    [BasicAuthorize("localhost")]
    public class AdviceDocumentController : Controller
    {
        // POST api/values
        [HttpPost]
        public void Post([FromHeader] string Authorization, [FromBody] IFormFile file)
        {
            var s = Authorization;
        }
        // public async Task<IActionResult> Post([FromBody] List<IFormFile> files)
        // {
        //     long size = files.Sum(f => f.Length);

        //     // full path to file in temp location
        //     var filePath = Path.GetTempFileName();

        //     foreach (var formFile in files)
        //     {
        //         if (formFile.Length > 0)
        //         {
        //             using (var stream = new FileStream(filePath, FileMode.Create))
        //             {
        //                 await formFile.CopyToAsync(stream);
        //             }
        //         }
        //     }

        //     // process uploaded files
        //     // Don't rely on or trust the FileName property without validation.

        //     return Ok(new { count = files.Count, size, filePath});
        // }
    }
}
