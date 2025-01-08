using Blazored.LocalStorage;
using Front.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:8000/")
});

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddMudServices();


await builder.Build().RunAsync();

