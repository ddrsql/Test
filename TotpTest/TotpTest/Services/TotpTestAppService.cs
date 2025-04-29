using Volo.Abp.Application.Services;
using TotpTest.Localization;

namespace TotpTest.Services;

/* Inherit your application services from this class. */
public abstract class TotpTestAppService : ApplicationService
{
    protected TotpTestAppService()
    {
        LocalizationResource = typeof(TotpTestResource);
    }
}