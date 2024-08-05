using DASSoluciones.AppERP.Frontend.BusinessObject.Core.Options;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddAppERPServices(appERPOptions =>
    builder.Configuration.GetRequiredSection(AppERPOptions.SectionKey).Bind(appERPOptions));
builder.Services.AddRadzenComponents();

await builder.Build().RunAsync();