# HTTP health check DI

[![CI CD](https://github.com/Arnab-Developer/ArnabDeveloper.HttpHealthCheck.DI/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/Arnab-Developer/ArnabDeveloper.HttpHealthCheck.DI/actions/workflows/ci-cd.yml)
![Nuget](https://img.shields.io/nuget/v/ArnabDeveloper.HttpHealthCheck.DI)

This is a library for 
[HTTP health check](https://github.com/Arnab-Developer/ArnabDeveloper.HttpHealthCheck) 
dependency injection for ASP.NET 5. It has been hosted in 
[NuGet](https://www.nuget.org/packages/ArnabDeveloper.HttpHealthCheck.DI/). 
Use below command to install this in your .NET application.

```
dotnet add package ArnabDeveloper.HttpHealthCheck.DI
```

Use the below code in `Startup.cs` to add HTTP health check into ASP.NET DI.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddHttpHealthCheck();
}
```

There is a 
[dashboard app](https://github.com/Arnab-Developer/HttpHealthCheckDashboard) 
which uses the library to check health of some http endpoints. This is to show 
how you can use this library in your app.
