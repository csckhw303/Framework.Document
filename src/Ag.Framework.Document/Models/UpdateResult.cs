namespace Ag.Framework.Document.Models;

public class UpdateResult
{
    public UpdateResult(long updatedCount)
    {
        UpdatedCount = updatedCount;
    }

    public long UpdatedCount { get; }
}