using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using SmartSchool.API.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SmartSchool.API
{
    /// <summary>
    /// StartUp Class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SmartContext>(context => context.UseSqlite(Configuration.GetConnectionString("DefaultConnectionString")));

            services.AddScoped<IRepository, Repository>();

            services.AddControllers().AddNewtonsoftJson(o => {
                o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddVersionedApiExplorer(opt =>
            {
                opt.GroupNameFormat = "'v'VVV";
                opt.SubstituteApiVersionInUrl = true;
            })
                .AddApiVersioning( opt =>
                {
                    opt.DefaultApiVersion = new ApiVersion(1, 0); 
                    opt.AssumeDefaultVersionWhenUnspecified = true;
                    opt.ReportApiVersions = true;
                });

            var apiProviderDescripton = services.BuildServiceProvider()
                .GetService<IApiVersionDescriptionProvider>();

            
            services.AddSwaggerGen(opt => {

                foreach(var description in apiProviderDescripton.ApiVersionDescriptions)
                {
                    opt.SwaggerDoc(description.GroupName, 
                        new Microsoft.OpenApi.Models.OpenApiInfo()
                        {

                        Title = "The Smart School API",
                        Version = description.ApiVersion.ToString(),
                        TermsOfService = new Uri("https://www.godoy.net"),
                        Description = "Documentação da API Smart School",
                        License = new Microsoft.OpenApi.Models.OpenApiLicense
                        {
                            Name = "The SmartSchool License",
                            Url = new Uri("https://www.godoy.net/license/smartschool")
                        },

                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Luiz Goody",
                            Email = "contato@godoy.net",
                            Url = new Uri("https://www.godoy.net")
                        }
                    });
                }                

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory,xmlCommentsFile);

                opt.IncludeXmlComments(xmlCommentsFullPath);
            });
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline. 
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="env">IWebHostEnvironment</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger()
                .UseSwaggerUI(opt => {

                    foreach(var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
                    {
                        opt.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToLowerInvariant());
                    }
                    opt.RoutePrefix = "";
                }); 
            
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}