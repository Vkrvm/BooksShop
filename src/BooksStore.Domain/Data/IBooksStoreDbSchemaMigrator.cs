using System.Threading.Tasks;

namespace BooksStore.Data;

public interface IBooksStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
