using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BooksStore.Blazor;

[Dependency(ReplaceServices = true)]
public class BooksStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BooksStore";
}
