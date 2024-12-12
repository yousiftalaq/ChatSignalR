using ChatSignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var Services = builder.Services;
Services.AddControllersWithViews();
Services.AddSignalR();
Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://192.168.3.102:5031")
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowCredentials();


    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//app.MapHub<ChatHub>("/chat");
app.MapHub<NotificationsHub>("/notificationsHub"); // SignalR Hub

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
