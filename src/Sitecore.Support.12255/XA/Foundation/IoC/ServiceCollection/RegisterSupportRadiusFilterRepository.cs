namespace Sitecore.Support.XA.Foundation.IoC.ServiceCollection
{
  using Microsoft.Extensions.DependencyInjection;
  using Sitecore.DependencyInjection;
  using Sitecore.XA.Feature.Search.Repositories;

  public class RegisterSupportRadiusFilterRepository : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddSingleton<IRadiusFilterRepository, Sitecore.Support.XA.Feature.Search.Repositories.RadiusFilterRepository>();
    }
  }
}