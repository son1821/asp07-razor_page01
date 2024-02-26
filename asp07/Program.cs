var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
{
    options.RootDirectory = "/Pages";
    options.Conventions.AddPageRoute("/Page", "/trangdautien.html");
    options.Conventions.AddPageRoute("/SecondPage", "/trangthuhai.html");
    options.Conventions.AddPageRoute("/ThirdPage", "/trangthuba.html");
});

builder.Services.Configure<RouteOptions>(routeOptions => { 
routeOptions.LowercaseUrls = true;

});

var app = builder.Build();



app.MapRazorPages();

app.Run();