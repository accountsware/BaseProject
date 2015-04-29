
using Angular.AuthInfrastructure.Configuration;
using Angular.AuthInfrastructure.Services;
using Angular.AuthInfrastructure.Services.InMemory;

namespace Angular.AuthServer.Config
{
    public class Factory
    {
        //public static IdentityServerServiceFactory Configure()
        //{
        //    var factory = new IdentityServerServiceFactory();

        //    var scopeStore = new InMemoryScopeStore(Scopes.Get());
        //    factory.ScopeStore = new Registration<IScopeStore>(resolver => scopeStore);

        //    var clientStore = new InMemoryClientStore(Clients.Get());
        //    factory.ClientStore = new Registration<IClientStore>(resolver => clientStore);

        //    return factory;
        //}
    }
}