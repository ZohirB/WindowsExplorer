using Microsoft.AspNetCore.Mvc;

namespace WindowsExplorer.Service
{
    public interface IManageImage
    {
        Task<string> UploadFile(IFormFile _IFormFile, int idFolder);
        Task<(byte[], string, string)> DownloadFile(string FileName, int idFolder);
    }
}
