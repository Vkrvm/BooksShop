using BooksStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BooksStore;

[DependsOn(
    typeof(BooksStoreEntityFrameworkCoreTestModule)
    )]
public class BooksStoreDomainTestModule : AbpModule
{

}
