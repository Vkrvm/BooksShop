using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BooksStore.Data;

/* This is used if database provider does't define
 * IBooksStoreDbSchemaMigrator implementation.
 */
public class NullBooksStoreDbSchemaMigrator : IBooksStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
