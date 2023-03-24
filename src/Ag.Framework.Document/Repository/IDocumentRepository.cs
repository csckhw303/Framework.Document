using System.Linq.Expressions;
using Ag.Framework.Document.Models;

namespace Ag.Framework.Document.Repository;

public interface IDocumentRepository
{
    IQueryable<TDocument> AsQueryable<TDocument>() where TDocument : DatabaseDocument;

    IEnumerable<TDocument> FilterBy<TDocument>(
        Expression<Func<TDocument, bool>> filterExpression) where TDocument : DatabaseDocument;

    IEnumerable<TProjected> FilterBy<TDocument, TProjected>(
        Expression<Func<TDocument, bool>> filterExpression,
        Expression<Func<TDocument, TProjected>> projectionExpression) where TDocument : DatabaseDocument;

    TDocument FindOne<TDocument>(Expression<Func<TDocument, bool>> filterExpression) where TDocument : DatabaseDocument;

    #region Find

    Task<TDocument> FindOneAsync<TDocument>(Expression<Func<TDocument, bool>> filterExpression)
        where TDocument : DatabaseDocument;

    TDocument FindById<TDocument>(string id) where TDocument : DatabaseDocument;

    Task<TDocument> FindByIdAsync<TDocument>(string id) where TDocument : DatabaseDocument;

    #endregion

    #region Insert

    void InsertOne<TDocument>(TDocument document) where TDocument : DatabaseDocument;

    Task InsertOneAsync<TDocument>(TDocument document) where TDocument : DatabaseDocument;

    void InsertMany<TDocument>(ICollection<TDocument> documents) where TDocument : DatabaseDocument;

    Task InsertManyAsync<TDocument>(ICollection<TDocument> documents) where TDocument : DatabaseDocument;

    #endregion

    #region Delete

    void DeleteOne<TDocument>(Expression<Func<TDocument, bool>> filterExpression) where TDocument : DatabaseDocument;

    Task DeleteOneAsync<TDocument>(Expression<Func<TDocument, bool>> filterExpression)
        where TDocument : DatabaseDocument;

    void DeleteById<TDocument>(string id) where TDocument : DatabaseDocument;

    Task DeleteByIdAsync<TDocument>(string id) where TDocument : DatabaseDocument;

    void DeleteMany<TDocument>(Expression<Func<TDocument, bool>> filterExpression) where TDocument : DatabaseDocument;

    Task DeleteManyAsync<TDocument>(Expression<Func<TDocument, bool>> filterExpression)
        where TDocument : DatabaseDocument;

    #endregion

    #region Upsert

    public UpdateResult Upsert<TDocument>(Expression<Func<TDocument, bool>> filter, TDocument document)
        where TDocument : DatabaseDocument;

    public Task<UpdateResult> UpsertAsync<TDocument>(Expression<Func<TDocument, bool>> filter, TDocument document)
        where TDocument : DatabaseDocument;

    #endregion

    #region Transaction

    public Task BeginTransactionAsync(string? transactionName = null);

    public Task<bool> CommitTransactionAsync();

    #endregion
}