using System;
using System.Collections.Generic;
using System.Text;
using BooksStore.Localization;
using Volo.Abp.Application.Services;

namespace BooksStore;

/* Inherit your application services from this class.
 */
public abstract class BooksStoreAppService : ApplicationService
{
    protected BooksStoreAppService()
    {
        LocalizationResource = typeof(BooksStoreResource);
    }
}
