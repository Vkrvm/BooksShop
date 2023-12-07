using Volo.Abp.Settings;

namespace BooksStore.Settings;

public class BooksStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BooksStoreSettings.MySetting1));
    }
}
