
using controle_contas.Application;
using controle_contas.Application.Interfaces;
using controle_contas.Domain.Interfaces.Repositories;
using controle_contas.Domain.Interfaces.Services;
using controle_contas.Domain.Services;
using controle_contas.Infra.Data.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace controle_contas.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new Container();

            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IPessoaFisicaAppService, PessoaFisicaAppService>(Lifestyle.Singleton);
            container.Register<IPessoaJuridicaAppService, PessoaJuridicaAppService>(Lifestyle.Singleton);
            container.Register<IContaAppService, ContaAppService>(Lifestyle.Singleton);
            container.Register<ITransacaoAppService, TransacaoAppService>(Lifestyle.Singleton);

            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IPessoaFisicaService, PessoaFisicaService>(Lifestyle.Singleton);
            container.Register<IPessoaJuridicaService, PessoaJuridicaService>(Lifestyle.Singleton);
            container.Register<IContaService, ContaService>(Lifestyle.Singleton);
            container.Register<ITransacaoService, TransacaoService>(Lifestyle.Singleton);

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IPessoaFisicaRepository, PessoaFisicaRepository>(Lifestyle.Singleton);
            container.Register<IPessoaJuridicaRepository, PessoaJuridicaRepository>(Lifestyle.Singleton);
            container.Register<IContaRepository, ContaRepository>(Lifestyle.Singleton);
            container.Register<ITransacaoRepository, TransacaoRepository>(Lifestyle.Singleton);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration); //web api          
            container.Verify();

            DependencyResolver.SetResolver(
               new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container); //web api


        }
    }
}
