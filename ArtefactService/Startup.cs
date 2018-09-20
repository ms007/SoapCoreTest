using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using SoapCore;
using IArtifactService = ArtefactService.Contracts.IArtifactService;

namespace ArtefactService
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddScoped<IArtifactService, ArtifactService>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();

            app.UseSoapEndpoint<IArtifactService>("/Service.svc", new BasicHttpBinding(), SoapSerializer.XmlSerializer);

            app.UseMvc();
        }
    }
}
