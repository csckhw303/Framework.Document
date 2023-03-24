namespace Ag.Framework.Document.Models;

public class FindResult<T> where T : DatabaseDocument
{
    public FindResult(IList<T> result)
    {
        Result = result;
    }

    public virtual IList<T> Result { get; }
}