using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
   options.ViewLocationFormats.Clear();
   options.ViewLocationFormats.Add("/Pages/{1}/{0}" + RazorViewEngine.ViewExtension);
   options.ViewLocationFormats.Add("/Pages/Shared/{0}" + RazorViewEngine.ViewExtension);
});
builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

//app.UseStatusCodePagesWithReExecute("/Error/Error/{0}");
//app.UseExceptionHandler("/Error/Error");

//app.UseStatusCodePagesWithReExecute("/Error/Error/{0}");
app.UseStatusCodePagesWithReExecute("/Error/Error", "?statusCode={0}");

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=ProductList}/{id?}");

app.Run();
