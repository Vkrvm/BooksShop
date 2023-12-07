using BooksStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BooksStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BooksStoreController : AbpControllerBase
{
    protected BooksStoreController()
    {
        LocalizationResource = typeof(BooksStoreResource);
    }
}
