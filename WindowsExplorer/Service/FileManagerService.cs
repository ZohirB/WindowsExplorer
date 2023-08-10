using Microsoft.AspNetCore.StaticFiles;
using WindowsExplorer.Helper;

namespace WindowsExplorer.Service;

public class FileManagerService : IFileManagerService
{
    public Task<string> UploadFile(IFormFile _IFormFile, string name, int idFolder)
    {
        throw new NotImplementedException();
    }

    public Task<string> CopyFile(int idFile, int idDestenationFolder)
    {
        throw new NotImplementedException();
    }

    public Task<string> MoveFile(int idFile, int idDestenationFolder)
    {
        throw new NotImplementedException();
    }

    public Task RemoveFile(int idFile)
    {
        throw new NotImplementedException();
    }

    public Task<string> RenameFileById(int idFile)
    {
        throw new NotImplementedException();
    }

    public Task<string> RenameFileByName(string FileName, int idFolder)
    {
        throw new NotImplementedException();
    }

    public Task<string> DownloadFileByName(string FileName, int idFolder)
    {
        throw new NotImplementedException();
    }

    public Task<string> DownloadFileById(int idFile)
    {
        throw new NotImplementedException();
    }
}