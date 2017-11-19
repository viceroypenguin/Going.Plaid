using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Acklann.Plaid.Demo
{
    public static class ExtensionMethods
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string rootDir)
        {
            var options = new StaticFileOptions()
            {
                RequestPath = "/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(rootDir, "node_modules"))
            };
            app.UseStaticFiles(options);

            return app;
        }
    }
}