# HTTP health check DI

This is a library for 
[HTTP health check](https://github.com/Arnab-Developer/ArnabDeveloper.HttpHealthCheck) 
dependency injection for ASP.NET. It has been hosted in 
[NuGet](https://www.nuget.org/packages/ArnabDeveloper.HttpHealthCheck.DI/). 
Use below command to install this in your .NET application.

```
dotnet add package ArnabDeveloper.HttpHealthCheck.DI
```

Use the below code in `Program.cs` to add HTTP health check into ASP.NET DI.

```csharp
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpHealthCheck();
```

There is a 
[dashboard app](https://github.com/Arnab-Developer/HttpHealthCheckDashboard) 
which uses the library to check health of some http endpoints. This is to show 
how you can use this library in your app.