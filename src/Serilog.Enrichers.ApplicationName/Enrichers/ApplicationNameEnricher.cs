using Microsoft.Extensions.PlatformAbstractions;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers.ApplicationName.Enrichers
{
	public class ApplicationNameEnricher : ILogEventEnricher
	{
		private LogEventProperty applicationName;

		public void Enrich( LogEvent logEvent, ILogEventPropertyFactory propertyFactory )
		{
			applicationName = applicationName ?? propertyFactory.CreateProperty(
				nameof(PlatformServices.Default.Application.ApplicationName),
				PlatformServices.Default.Application.ApplicationName.ToLowerInvariant() );

			logEvent.AddPropertyIfAbsent( applicationName );
		}
	}
}
