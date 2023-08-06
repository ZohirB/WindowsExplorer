using Microsoft.AspNetCore.StaticFiles;
using WindowsExplorer.Helper;

namespace WindowsExplorer.Service
{
    public class ManageImage : IManageImage
    {
        public async Task<string> UploadFile(IFormFile _IFormFile, int idFolder)
        {
            string FileName = "";
            try
            {
                FileInfo _FileInfo = new FileInfo(_IFormFile.FileName);
                var FileFirstExtName = "--" + DateTime.Now.Ticks.ToString() +  "--";
                FileName = FileFirstExtName + _IFormFile.FileName;
                var _GetFilePath = PathHelper.GetFilePath(FileName,idFolder);
                using (var _FileStream = new FileStream(_GetFilePath, FileMode.Create))
                {
                    await _IFormFile.CopyToAsync(_FileStream);
                }
                return FileName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<(byte[], string, string)> DownloadFile(string FileName, int idFolder)
        {
            try
            {
                var _GetFilePath = PathHelper.GetFilePath(FileName,idFolder);
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(_GetFilePath, out var _ContentType))
                {
                    _ContentType = "application/octet-stream";
                }
                var _ReadAllBytesAsync = await File.ReadAllBytesAsync(_GetFilePath);
                return (_ReadAllBytesAsync, _ContentType, Path.GetFileName(_GetFilePath));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
