using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImageUploadController : ControllerBase
{
    private readonly IWebHostEnvironment hosting;

    public ImageUploadController(IWebHostEnvironment _hosting)
    {
        hosting = _hosting;
    }

    [HttpPost]
    public IActionResult SaveImage(IFormFile file)
    {
        string webRootPath = hosting.WebRootPath;
        string absolutePath = Path.Combine($"{webRootPath}/images/{file.FileName}");
        
        using (var fileStream = new FileStream(absolutePath, FileMode.Create))
        {
            file.CopyTo(fileStream);
        }

        return Ok();
    }
};