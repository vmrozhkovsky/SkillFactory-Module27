﻿using System.IO;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace LifeSpot
{
    public static class EndpointMapper
    {
        public static void MapCss(this IEndpointRouteBuilder builder)
        {
            var cssFiles = new[] { "index.css", "about.css" };
          
            foreach (var fileName in cssFiles)
            {
                builder.MapGet($"/Static/CSS/{fileName}", async context =>
                {
                    var cssPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "CSS", fileName);
                    var css = await File.ReadAllTextAsync(cssPath);
                    await context.Response.WriteAsync(css);
                });
            }
        }
        public static void MapJs(this IEndpointRouteBuilder builder)
        {
            var jsFiles = new[] { "feedback.js", "index.js", "testing.js", "search.js" };
  
            foreach (var fileName in jsFiles)
            {
                builder.MapGet($"/Static/JS/{fileName}", async context =>
                {
                    var jsPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "JS", fileName);
                    var js = await File.ReadAllTextAsync(jsPath);
                    await context.Response.WriteAsync(js);
                });
            }
        }
        public static void MapHtml(this IEndpointRouteBuilder builder)
        {
            string headerHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "header.html"));
            string footerHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "footer.html"));
            string sideBarHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "sidebar.html"));
            
            builder.MapGet("/", async context =>
            {
                var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "index.html");
                var viewText = await File.ReadAllTextAsync(viewPath);
      
                // Загружаем шаблон страницы, вставляя в него элементы
                var html =  new StringBuilder(await File.ReadAllTextAsync(viewPath))
                    .Replace("<!--HEADER-->", headerHtml)
                    .Replace("<!--SIDEBAR-->", sideBarHtml)
                    .Replace("<!--FOOTER-->", footerHtml);
      
                await context.Response.WriteAsync(html.ToString());
            });
  
            builder.MapGet("/Testing", async context =>
            {
                var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "testing.html");
      
                // Загружаем шаблон страницы, вставляя в него элементы
                var html =  new StringBuilder(await File.ReadAllTextAsync(viewPath))
                    .Replace("<!--HEADER-->", headerHtml)
                    .Replace("<!--SIDEBAR-->", sideBarHtml)
                    .Replace("<!--FOOTER-->", footerHtml);
      
                await context.Response.WriteAsync(html.ToString());
            });
  
            builder.MapGet("/About", async context =>
            {
                var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "about.html");
      
                // Загружаем шаблон страницы, вставляя в него элементы
                var html =  new StringBuilder(await File.ReadAllTextAsync(viewPath))
                    .Replace("<!--HEADER-->", headerHtml)
                    .Replace("<!--SIDEBAR-->", sideBarHtml)
                    .Replace("<!--FOOTER-->", footerHtml);
      
                await context.Response.WriteAsync(html.ToString());
            });
        }
    }
}