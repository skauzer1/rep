using Grocer.Common;
using Grocer.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Grocer {
    public class Startup {
        private readonly string StoreUriName = "StoreUrl"; 

        public Startup(IConfiguration configuration) { Configuration = configuration; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc();
            services.AddSingleton(new StoreUriProvider(Configuration.GetValue<string>(StoreUriName)));
            services.AddScoped<StoreClient>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

            app.UseMvc();
        }
    }
}
