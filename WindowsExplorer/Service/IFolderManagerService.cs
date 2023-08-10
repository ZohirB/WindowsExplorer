namespace WindowsExplorer.Service;

public interface IFolderManagerService
{
    //Upload Section
    Task<string> CreateFolder(string folderName, int idParentFolder);
    
    //Copy Section
    Task<string> CopyFolder(int idSourceFolder, int idDestenationFolder);
    
    //Move Section
    Task<string> MoveFolder(int idSourceFolder, int idDestenationFolder);
    
    //Remove Section
    Task RemoveFolder(int idFolder);
    
    //Rename Section
    Task<string> RenameFolderById(int idFolder);
}