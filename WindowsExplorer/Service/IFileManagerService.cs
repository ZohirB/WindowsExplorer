namespace WindowsExplorer.Service;

public interface IFileManagerService
{
    //Upload Section
    Task<string> UploadFile(IFormFile _IFormFile, string name, int idFolder);
    
    //Copy Section
    Task<string> CopyFile(int idFile, int idDestenationFolder);
    
    //Move Section
    Task<string> MoveFile(int idFile, int idDestenationFolder);
    
    //Remove Section
    Task RemoveFile(int idFile);
    
    //Rename Section
    Task<string> RenameFileById(int idFile);
    Task<string> RenameFileByName(string FileName, int idFolder);
    
    //Download Section
    Task<string> DownloadFileByName(string FileName, int idFolder);
    Task<string> DownloadFileById(int idFile);
}