namespace Ag.Framework.Document.Models;

public class DatabaseDocument
{
    public DatabaseDocument()
    {
        CreateDateTime = DateTime.Now;
        Version = -1;
    }

    public long Version { get; set; }
    public DateTime CreateDateTime { get; set; }
}