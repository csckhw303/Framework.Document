namespace Ag.Framework.Document.Models;

public class InsertResult
{
    public InsertResult(long insertedCount)
    {
        InsertedCount = insertedCount;
    }

    public long InsertedCount { get; }
}