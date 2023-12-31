﻿using WindowsExplorer.Service;
using Microsoft.AspNetCore.Mvc;

namespace WindowsExplorer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileManagerController : Controller
    {
        private readonly IFileManagerService _fileManagerService;
        public FileManagerController(IFileManagerService fileManagerService)
        {
            _fileManagerService = fileManagerService;
        }
        
        [HttpGet]
        public async Task<string> DownloadFileById(int idFolder)
        {
            var result = await _fileManagerService.DownloadFileById(idFolder);
            return result;
        }
        
        [HttpGet]
        public async Task<string> DownloadFileByName(string fileName, int idFolder)
        {
            var result = await _fileManagerService.DownloadFileByName(fileName, idFolder);
            return result;
        }
        
        [HttpPost]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile iFormFile, string fileName, int idFolder)
        {
            var result = await _fileManagerService.UploadFile(iFormFile, fileName, idFolder);
            if (result != "")
            {
                return Ok(result); 
            }
            else
            {
                return NotFound(result);
            }
        }
                
        [HttpPost]
        public async Task<IActionResult> CopyFile(int idFile, int idDestenationFolder)
        {
            var result = await _fileManagerService.CopyFile(idFile, idDestenationFolder);
            if (result != "")
            {
                return Ok(result); 
            }
            else
            {
                return NotFound(result);
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> MoveFile(int idFile, int idDestenationFolder)
        {
            var result = await _fileManagerService.MoveFile(idFile, idDestenationFolder);
            if (result != "")
            {
                return Ok(result); 
            }
            else
            {
                return NotFound(result);
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> RenameFileById(int idFile)
        {
            var result = await _fileManagerService.RenameFileById(idFile);
            if (result != "")
            {
                return Ok(result); 
            }
            else
            {
                return NotFound(result);
            }
        }
        [HttpPost]
        public async Task<IActionResult> RenameFileByName(string fileName, int idFolder)
        {
            var result = await _fileManagerService.RenameFileByName(fileName, idFolder);
            if (result != "")
            {
                return Ok(result); 
            }
            else
            {
                return NotFound(result);
            }
        }
        
        [HttpDelete]
        public async Task<IActionResult> RemoveFile(int idFile)
        {
            var result = _fileManagerService.RemoveFile(idFile);
            return Ok(result);
        }
    }
}
