using System.Web.Mvc;
using Unity.Mvc5;
using Unity;
using DataAccessLayer;
using CustomerServices;

namespace DependencyInjectionMVC
{
   
    public static class UnityConfig
    {
        
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerService, CustomerService>();

               

            
          
        }
    }
}