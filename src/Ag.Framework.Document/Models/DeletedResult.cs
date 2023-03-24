namespace Ag.Framework.Document.Models;

public class DeletedResult
{
    public DeletedResult(long deletedCount)
    {
        DeletedCount = deletedCount;
    }

    public long DeletedCount { get; }
}