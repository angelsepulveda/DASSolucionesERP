using DASSoluciones.AppERP.Backend.IoC;
using DASSoluciones.AppERP.EFCore.DataSources.Core.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAppERPServices(dbOptions =>
    builder.Configuration.GetRequiredSection(DBOptions.SectionKey).Bind(dbOptions));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAppERPEndpoints();
app.UseCors();

app.Run();