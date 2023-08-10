using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using WindowsExplorer.Helper;
using WindowsExplorer.Models;
using FileInfo = System.IO.FileInfo;

namespace WindowsExplorer.Service;

public class FileManagerService : IFileManagerService
{
    private readonly ApplicationDbContext _context;

    public FileManagerService(ApplicationDbContext context)
    {
        _context = context;
    }
    
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

    public FileInfo RemoveFile(int idFile)
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

    public async Task<bool> isValidFileId(int idFile)
    {
        var isValidcompanyName = await _context.FileInfo.AnyAsync(fi => fi.Id == idFile);
        return (isValidcompanyName) ? true :  false;
    }
    
}