using BooksStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BooksStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BooksStoreEntityFrameworkCoreModule),
    typeof(BooksStoreApplicationContractsModule)
    )]
public class BooksStoreDbMigratorModule : AbpModule
{
}
