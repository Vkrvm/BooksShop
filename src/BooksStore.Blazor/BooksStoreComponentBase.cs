using BooksStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BooksStore.Blazor;

public abstract class BooksStoreComponentBase : AbpComponentBase
{
    protected BooksStoreComponentBase()
    {
        LocalizationResource = typeof(BooksStoreResource);
    }
}
