# Serilog.Enrichers.ApplicationName

Enriches Serilog events with the application name.

[![NuGet Version](http://img.shields.io/nuget/v/Serilog.Enrichers.ApplicationName.svg?style=flat)](https://www.nuget.org/packages/Serilog.Enrichers.ApplicationName/)

To use the enricher, first install the NuGet package:

```powershell
Install-Package Serilog.Enrichers.ApplicationName
```

Then, apply the enricher to you `LoggerConfiguration`:

```csharp
Log.Logger = new LoggerConfiguration()
    .Enrich.WithApplicationName()
    // ...other configuration...
    .CreateLogger();
```

The `WithApplicationName()` enricher will add a `ApplicationName` property to produced events.

### Included enrichers

The package includes:

 * `WithApplicationName()` - adds `ApplicationName` based on `PlatformServices` class as a lower invariant string

Copyright &copy; 2018 engelbert strauss GmbH &amp; Co KG.