using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Data;
using Store.Infrastructure.Providers;
using Swashbuckle.AspNetCore.Swagger;

namespace Store {
    public class Startup {
        private readonly string DbConnectionName = "StoreDatabase";

        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new Info { Title = "Home API", Version = "v1" });
            });
            services.AddDbContext<StoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString(DbConnectionName)));
            services.AddScoped<IStoreProvider, StoreProvider>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Store API V1");
                });
            }
            app.UseMvc();
        }
    }
}
