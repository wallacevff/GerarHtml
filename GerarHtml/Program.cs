using GerarHtml.Services.DinkToPdf;
using GerarHtml.Services.RazorLight;
using GerarHtml.Services.Template;

var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.UseWebRoot("wwwroot");
//
//builder.Services.AddScoped<ITemplateService, TemplateService>();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRazorLight();
builder.Services.AddSingleton<ITemplateService, TemplateService>();
builder.Services.AddDinkToPdf();
builder.Services.AddSingleton<IDinkToPdfService, DinkToPdfService>();
//builder.Services.AddMvc();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
