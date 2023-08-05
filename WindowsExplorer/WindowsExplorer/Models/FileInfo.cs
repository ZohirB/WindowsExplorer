namespace WindowsExplorer.Models;
public class FileInfo
{
    public int Id { get; set; }
    public string FileName { get; set; }
    public int IdFolder { get; set; }
    public FolderInfo FolderInfo { get; set; }
}