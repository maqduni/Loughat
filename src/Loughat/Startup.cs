using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Model;
using Microsoft.Extensions.PlatformAbstractions;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Loughat.Filters;
using Raven.Client.Documents;
using Loughat.Services;

namespace Loughat
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            _environment = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
        private IHostingEnvironment _environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);
            services.AddMvc(
                config => {
                    if (!_environment.IsDevelopment())
                    {
                        config.Filters.Add(typeof(ExceptionFilter));
                    }
                }
            );

            // Add swagger documentation generator
            var xmlPath = GetXmlCommentsPath();
            services.AddSwaggerGen();
            services.ConfigureSwaggerGen(options =>
            {
                // TODO: Look at multiple api versions
                options.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "Loughat API",
                    Description = "Loughat dictionary Web API",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Iskandar Rafiev", Email = "irafiev@gmail.com" }
                });
                options.IncludeXmlComments(xmlPath);
                options.DescribeAllEnumsAsStrings();
            });

            // RavenDB services
            services.AddSingleton(Store.Documents);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // TODO: Configure logging to a file
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            // This block should only be used in dev mode
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUi();
            app.UseStaticFiles();
        }

        private string GetXmlCommentsPath()
        {
            var app = PlatformServices.Default.Application;
            return System.IO.Path.Combine(app.ApplicationBasePath, "Loughat.xml");
        }
    }
}
