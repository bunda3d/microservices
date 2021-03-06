using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Ordering.Infrastructure.Data;

using System;
using System.Threading.Tasks;

namespace Ordering.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();
			CreateAndSeedDatabase(host);
			host.Run();
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
				Host.CreateDefaultBuilder(args)
						.ConfigureWebHostDefaults(webBuilder =>
						{
							webBuilder.UseStartup<Startup>();
						});

		private static void CreateAndSeedDatabase(IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				var loggerFactory = services.GetRequiredService<ILoggerFactory>();

				try
				{
					var orderContext = services.GetRequiredService<OrderContext>();
					Task task = OrderContextSeed.SeedAsync(orderContext, loggerFactory);
				}
				catch (Exception exception)
				{
					var logger = loggerFactory.CreateLogger<Program>();
					logger.LogError(exception.Message);

					throw;
				}
			}
		}
	}
}