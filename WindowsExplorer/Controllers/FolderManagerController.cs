using Microsoft.AspNetCore.Mvc;
using WindowsExplorer.Service;

namespace WindowsExplorer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolderManagerController : Controller
    {
        private IFolderManagerService _folderManagerService;

        public FolderManagerController(IFolderManagerService folderManagerService)
        {
            this._folderManagerService = folderManagerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFolder(string folderName, int idParentFolder)
        {
            var result = await _folderManagerService.CreateFolder(folderName, idParentFolder);
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
        public async Task<IActionResult> CopyFolder(int idSourceFolder, int idDestenationFolder)
        {
            var result = await _folderManagerService.CopyFolder(idSourceFolder, idDestenationFolder);
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
        public async Task<IActionResult> MoveFolder(int idSourceFolder, int idDestenationFolder)
        {
            var result = await _folderManagerService.MoveFolder(idSourceFolder, idDestenationFolder);
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
        public async Task<IActionResult> RenameFolderById(int idFolder)
        {
            var result = await _folderManagerService.RenameFolderById(idFolder);
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
        public async Task<IActionResult> RemoveFolder(int idFolder)
        {
            var result = _folderManagerService.RemoveFolder(idFolder);
            return Ok(result);
        }
    }
}