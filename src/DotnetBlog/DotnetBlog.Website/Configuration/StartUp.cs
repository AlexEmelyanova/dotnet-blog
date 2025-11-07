namespace DotnetBlog.Website.Configuration;

public class StartUp
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration config, IWebHostEnvironment environment)
    {
        services.AddControllersWithViews();
        
    }

    public static void ConfigureApp(WebApplication app)
    {
        app.UseStaticFiles();
        app.UseRouting();
        //app.UseAuthorization();
        app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    }


}
