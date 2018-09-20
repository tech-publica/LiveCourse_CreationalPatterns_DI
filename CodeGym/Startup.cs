using CodeGym.Models.Core.Repositories;
using CodeGym.Models.Core.UnitOfWorks;
using CodeGym.Models.EF;
using CodeGym.Models.EF.Repositories;
using CodeGym.Models.EF.UnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodeGym
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CodeGymContext>(opts => opts.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<CourseRepository, EFCourseRepository>();
            services.AddTransient<CourseEditionRepository, EFCourseEditionRepository>();
            services.AddTransient<EnrollmentRepository, EFEnrollmentRepository>();
            services.AddTransient<CourseEditionUnitOfWork, EFCourseEditionUnitOfWork>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
