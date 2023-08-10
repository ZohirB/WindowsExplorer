using WindowsExplorer.Service;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadDownload.Controllers
{
    [ApiController]
    public class FileManagerController : ControllerBase
    {
        private readonly IManageImage _iManageImage;
        public FileManagerController(IManageImage iManageImage)
        {
            _iManageImage = iManageImage;
        }

        [HttpGet]
        [Route("downloadfile")]
        public async Task<IActionResult> DownloadFile(string FileName, int idFolder)
        {
            var result = await _iManageImage.DownloadFile(FileName, idFolder);
            return File(result.Item1, result.Item2, result.Item2);
        }
        
        [HttpPost]
        [Route("uploadfile")]
        public async Task<IActionResult> UploadFile(IFormFile _IFormFile,int idFolder)
        {
            var result = await _iManageImage.UploadFile(_IFormFile,idFolder);
            return Ok(result);
        }
    }
}
