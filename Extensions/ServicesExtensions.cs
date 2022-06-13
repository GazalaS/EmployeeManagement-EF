using EmployeeManagement.Repository;

namespace EmployeeManagement.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            //setup our DI
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();       
        }
    }
}
