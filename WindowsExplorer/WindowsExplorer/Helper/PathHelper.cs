namespace WindowsExplorer.Helper;

public class PathHelper
{
    //headup dir (ex... C:\\Users\\zohir\\OneDrive\\Desktop\\Training Projects\\WindowsExplorer\\WindowsExplorer\\WindowsExplorer)

    public static string GetCurrentDirectory() 
    {
        var result = Directory.GetCurrentDirectory();
        return result;
    }
    public static string GetStaticContentDirectory() 
    {
        var result = Path.Combine(Directory.GetCurrentDirectory(), "Uploads\\StaticContent\\");
        if (!Directory.Exists(result))
        {
            Directory.CreateDirectory(result);
        }
        return result;
        //headup dir (ex... C:\\Users\\zohir\\OneDrive\\Desktop\\Training Projects\\WindowsExplorer\\WindowsExplorer\\WindowsExplorer\\Uploads\\StaticContent\\)
    }
    public static string GetFilePath(string FileName,int idFolder)
    {
        var _GetStaticContentDirectory = GetStaticContentDirectory();
        var result = Path.Combine(_GetStaticContentDirectory, FileName);
        return result;
    }
}