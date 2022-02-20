global using BlazorWASMnet6BasicFilm.Client.Services.FilmService;
global using BlazorWASMnet6BasicFilm.Shared;
using BlazorWASMnet6BasicFilm.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFilmService, FilmService>();

await builder.Build().RunAsync();
