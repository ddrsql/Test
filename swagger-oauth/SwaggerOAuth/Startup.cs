using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace SwaggerOAuth
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option =>
            {
                option.Filters.Add(typeof(ActionFilter));
                option.Filters.Add(typeof(ExceptionFilter));
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            string youAuthority = "http://127.0.0.1";
            services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = youAuthority;
                    options.ApiName = "Api";
                    options.RequireHttpsMetadata = false;
                });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "Test Service API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);

                options.AddSecurityDefinition("oauth2", new OAuth2Scheme
                {
                    Type = "oauth2",
                    Flow = "implicit",
                    AuthorizationUrl = $"{youAuthority}/connect/authorize",
                    TokenUrl = $"{youAuthority}/connect/token",
                    Scopes = new Dictionary<string, string>()
                    {
                        { "scope", "定义的scope" }  //Api Resources 中的 scope
                    }
                });

                options.OperationFilter<AuthResponsesOperationFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMiddleware<FirstMiddleware>();

            app.UseMvc();
            
            app.UseSwagger().
                UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Test Service API");
                    //支持 implicit 的 Client
                    options.OAuthClientId("swaggerui");
                    options.OAuthAppName("Test Service Swagger Ui");
                });
        }
    }
}
