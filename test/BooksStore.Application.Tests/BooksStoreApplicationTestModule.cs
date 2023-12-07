using Volo.Abp.Modularity;

namespace BooksStore;

[DependsOn(
    typeof(BooksStoreApplicationModule),
    typeof(BooksStoreDomainTestModule)
    )]
public class BooksStoreApplicationTestModule : AbpModule
{

}
