namespace WindowsExplorer.Service;

public class FolderManagerService : IFolderManagerService
{
    public async Task<string> CreateFolder(string folderName, int idParentFolder)
    {
        throw new NotImplementedException();
    }

    public Task<string> CopyFolder(int idSourceFolder, int idDestenationFolder)
    {
        throw new NotImplementedException();
    }

    public Task<string> MoveFolder(int idSourceFolder, int idDestenationFolder)
    {
        throw new NotImplementedException();
    }

    public Task RemoveFolder(int idFile)
    {
        throw new NotImplementedException();
    }

    public Task<string> RenameFolderById(int idFile)
    {
        throw new NotImplementedException();
    }
}