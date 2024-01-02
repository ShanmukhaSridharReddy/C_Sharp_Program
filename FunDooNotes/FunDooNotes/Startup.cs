using BusinessLayer.InterFace;
using BusinessLayer.Sessions;
using MassTransit;
using MassTransit.AspNetCoreIntegration;
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
using RepositoryLayer.Context;
using RepositoryLayer.InterFace;
using RepositoryLayer.Sessiions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunDooNotes
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
            services.AddControllers();
            services.AddDbContext<FunDooContext>(con => con.UseSqlServer(Configuration["ConnectionStrings:FunDooNotes"]));
            services.AddTransient<IUserBusiness, UserBusiness>();
            services.AddTransient<IUserRepo, UserRepo>();
            services.AddTransient<INotesBusiness, NotesBusiness>();
            services.AddTransient<INotesRepo, NotesRepo>();
            services.AddTransient<ILabelBusiness, LabelBusiness>();
            services.AddTransient<ILabelRepo, LabelRepo>();
            services.AddTransient<ICollaboratorBusiness, CollaboratorBusiness>();
            services.AddTransient<ICollaboratorRepo, CollaboratorRepo>();
            services.AddDistributedMemoryCache();

            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "Jwt",
                    Scheme = "Bearer"
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                             new OpenApiSecurityScheme
                             {
                                Reference = new OpenApiReference
                                {
                                    Type=ReferenceType.SecurityScheme,
                                    Id="Bearer"
                                }
                             },
                             new string[]{}
                        }
                });
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                var Key = Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]);
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Key)
                };
            });

            //services.AddSingleton<IJWTManagerRepository, JWTManagerRepository>();

            services.AddControllers();
        

        services.AddMassTransit(x =>
            {
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config =>
                {
                    config.UseHealthCheck(provider);
                    config.Host(new Uri("rabbitmq://localhost"), h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });
                }));
            });
            services.AddMassTransitHostedService();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // This middleware serves the Swagger documentation UI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FunDooNotes API V1");
            });


            app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
