using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bookadoc.Api.Models;
using Bookadoc.Core.Data;
using Bookadoc.Data.EntityFramework;
using Bookadoc.Data.EntityFramework.Seed;
using Microsoft.EntityFrameworkCore;
using Bookadoc.Data.EntityFramework.Repositories;
using Microsoft.Extensions.Logging;
using GraphQL;
using GraphQL.Types;

namespace Bookadoc.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private IHostingEnvironment Env { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<UserQuery>();
            services.AddTransient<IUserRepository, UserRepository>();

            if(Env.IsEnvironment("Test"))
            {
                services.AddDbContext<BookadocContext>(options => options.UseInMemoryDatabase(databaseName: "Bookadoc"));
            }
            else
            {
                services.AddDbContext<BookadocContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BookadocDatabaseConnection"))
                );
            }

            services.AddTransient<IDocumentExecuter, DocumentExecuter>();
            
            var sp = services.BuildServiceProvider();
            services.AddTransient<ISchema>(_ => new Schema { Query = sp.GetService<UserQuery>() });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory, BookadocContext db)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                db.EnsureSeedData();
            }

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
