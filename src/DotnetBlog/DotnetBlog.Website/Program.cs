using DotnetBlog.Website.Configuration;

namespace DotnetBlog.Website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            StartUp.ConfigureServices(builder.Services, builder.Configuration, builder.Environment);

            var app = builder.Build();
            StartUp.ConfigureApp(app);

            app.Run();
        }
    }
}
