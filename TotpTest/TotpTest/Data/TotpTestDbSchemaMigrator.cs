using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TotpTest.Data;

public class TotpTestDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public TotpTestDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the TotpTestDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TotpTestDbContext>()
            .Database
            .MigrateAsync();

    }
}
