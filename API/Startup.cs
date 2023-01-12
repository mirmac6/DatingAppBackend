using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Middleware;
using API.Services;
using API.SignalR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace API
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            
            _config = config;
        }   

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationServices(_config);
        //    var connString = "";
        //    if (env.IsDevelopment())
        //    {
        //        connString = ConfigurationExtensions.GetConnectionString(_config, "AppConnectionString");
        //    }
        //    else
        //    {
        //        // Use connection string provided at runtime by fly.io.
        //        var connUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

        //        // Parse connection URL to connection string for Npgsql
        //        connUrl = connUrl.Replace("postgres://", string.Empty);
        //        var pgUserPass = connUrl.Split("@")[0];
        //        var pgHostPortDb = connUrl.Split("@")[1];
        //        var pgHostPort = pgHostPortDb.Split("/")[0];
        //        var pgDb = pgHostPortDb.Split("/")[1];
        //        var pgUser = pgUserPass.Split(":")[0];
        //        var pgPass = pgUserPass.Split(":")[1];
        //        var pgHost = pgHostPort.Split(":")[0];
        //        var pgPort = pgHostPort.Split(":")[1];

        //        connString = $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb};";
        //}
        //services.AddDbContext<DataContext>(options =>
        //options.UseNpgsql(connString));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });
            services.AddCors();
            services.AddIdentityServices(_config);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, DataContext context, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            //context.Database.ExecuteSqlRaw("DELETE FROM [Connections]");
            context.Connections.RemoveRange(context.Connections);
            context.SaveChanges();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(policy=>policy.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
            .WithOrigins("https://localhost:4200"));

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapHub<PresenceHub>("hubs/presence");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<PresenceHub>("hubs/presence"); // dodato za signalR
                endpoints.MapHub<MessageHub>("hubs/message"); // dodato za signalR
                endpoints.MapFallbackToController("Index", "Fallback");
            });
        }
    }
}
