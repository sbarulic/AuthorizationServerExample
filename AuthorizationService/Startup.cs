using Owin;
using AuthorizationService.Config;
using Thinktecture.IdentityServer.Core.Configuration;

namespace AuthorizationService
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var factory = InMemoryFactory.Create(
                users: Users.Get(),
                clients: Clients.Get(),
                scopes: Scopes.Get());

            var options = new IdentityServerOptions
            {
                IssuerUri = "https://idsrv3.com",
                SiteName = "Thinktecture IdentityServer v3 - preview 1 (SelfHost)",
                PublicHostName = "http://localhost:3333",
               
                //SigningCertificate = Certificate.Get(),
                Factory = factory,
            };

            appBuilder.UseIdentityServer(options);
        }
    }
}
