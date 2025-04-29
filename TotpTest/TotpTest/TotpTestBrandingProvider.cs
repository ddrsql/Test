using Microsoft.Extensions.Localization;
using TotpTest.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TotpTest;

[Dependency(ReplaceServices = true)]
public class TotpTestBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TotpTestResource> _localizer;

    public TotpTestBrandingProvider(IStringLocalizer<TotpTestResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}