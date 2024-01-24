// using System.IO;
// using System.Text;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Http;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
//  
// namespace LifeSpot
// {
//    public class Startup
//    {
//        public void ConfigureServices(IServiceCollection services)
//        {
//        }
//  
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//                app.UseDeveloperExceptionPage();
//  
//            app.UseRouting();
//          
//            // Загружаем отдельные элементы для вставки в шаблон: боковое меню и футер
//            string headerHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "header.html"));
//            string footerHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "footer.html"));
//            string sideBarHtml =  File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "sidebar.html"));
//  
//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapGet("/", async context =>
//                {
//                    var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "index.html");
//                    
//                    var html =  new StringBuilder(await File.ReadAllTextAsync(viewPath))
//                        .Replace("<!--HEADER-->", headerHtml)
//                        .Replace("<!--SIDEBAR-->", sideBarHtml)
//                        .Replace("<!--FOOTER-->", footerHtml);
//                   
//                    await context.Response.WriteAsync(html.ToString());
//                });
//               
//                endpoints.MapGet("/Testing", async context =>
//                {
//                    var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Testing", "testing.html");
//                    
//                    var html =  new StringBuilder(await File.ReadAllTextAsync(viewPath))
//                        .Replace("<!--HEADER-->", headerHtml)
//                        .Replace("<!--SIDEBAR-->", sideBarHtml)
//                        .Replace("<!--FOOTER-->", footerHtml);
//                   
//                    await context.Response.WriteAsync(html.ToString());
//                });
//                endpoints.MapGet("/About", async context =>
//                {
//                    var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "about.html");
//                    
//                    var html =  new StringBuilder(await File.ReadAllTextAsync(viewPath))
//                        .Replace("<!--HEADER-->", headerHtml)
//                        .Replace("<!--SIDEBAR-->", sideBarHtml)
//                        .Replace("<!--FOOTER-->", footerHtml);
//                   
//                    await context.Response.WriteAsync(html.ToString());
//                });
//               
//                endpoints.MapGet("/Static/CSS/index.css", async context =>
//                {
//                    var cssPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "CSS", "index.css");
//                    var css = await File.ReadAllTextAsync(cssPath);
//                    await context.Response.WriteAsync(css);
//                });
//                endpoints.MapGet("/Static/CSS/about.css", async context =>
//                {
//                    var cssPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "CSS", "about.css");
//                    var css = await File.ReadAllTextAsync(cssPath);
//                    await context.Response.WriteAsync(css);
//                });
//               
//                endpoints.MapGet("/Static/JS/index.js", async context =>
//                {
//                    var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", "index.js");
//                    var js = await File.ReadAllTextAsync(jsPath);
//                    await context.Response.WriteAsync(js);
//                });
//                endpoints.MapGet("/Static/JS/testing.js", async context =>
//                {
//                    var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", "testing.js");
//                    var js = await File.ReadAllTextAsync(jsPath);
//                    await context.Response.WriteAsync(js);
//                });
//                endpoints.MapGet("/Static/JS/search.js", async context =>
//                {
//                    var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", "search.js");
//                    var js = await File.ReadAllTextAsync(jsPath);
//                    await context.Response.WriteAsync(js);
//                });
//                endpoints.MapGet("/Static/JS/feedback.js", async context =>
//                {
//                    var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", "feedback.js");
//                    var js = await File.ReadAllTextAsync(jsPath);
//                    await context.Response.WriteAsync(js);
//                });
//            });
//        }
//    }
// }

using LifeSpot;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
    }
 
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();
 
        app.UseRouting();
      
        app.UseEndpoints(endpoints =>
        {
            // Маппинг статических файлов
          
            endpoints.MapCss();
            endpoints.MapJs();
            endpoints.MapHtml();
        });
    }
}