using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace University.Infrastructure
{
    public class CreateDbHostService : BackgroundService
    {
        private readonly ApplicationContext _context;

        public CreateDbHostService( ApplicationContext context)
        {
            _context = context;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            await _context.Database.MigrateAsync(stoppingToken);
            await base.StopAsync(stoppingToken);

        }
    }
}

