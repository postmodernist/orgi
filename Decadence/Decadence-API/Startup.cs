using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Decadence_DAL.Services;
using Decadence_DAL.Interfaces;
using Decadence_DAL.UnitOfWork;
using Decadence_DAL.Infrastucture;
using Decadence_DAL.Repositories;
 

namespace Decadence
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
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Decadence", Version = "v1" });
            //});

            #region Repositories
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IFilterRepository ,FilterRepository>();
            services.AddTransient<ILabelRepository, LabelRepository>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IWorkItemRepository, WorkItemRepository>();
            #endregion

            #region services

            services.AddTransient<ILabelService, LabelService>();
            services.AddTransient<IFilterService, FilterService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IWorkItemService, WorkItemService>();
            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IConnectionFactory, ConnectionFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Decadence v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
