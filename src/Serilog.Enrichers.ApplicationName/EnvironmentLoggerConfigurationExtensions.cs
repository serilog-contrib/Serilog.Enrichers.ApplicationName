using System;
using Serilog.Configuration;
using Serilog.Enrichers.ApplicationName.Enrichers;

namespace Serilog
{
	public static class EnvironmentLoggerConfigurationExtensions
	{
		public static LoggerConfiguration WithApplicationName( this LoggerEnrichmentConfiguration enrichmentConfiguration )
		{
			if( enrichmentConfiguration == null ) throw new ArgumentNullException( nameof(enrichmentConfiguration) );

			return enrichmentConfiguration.With<ApplicationNameEnricher>();
		}
	}
}
