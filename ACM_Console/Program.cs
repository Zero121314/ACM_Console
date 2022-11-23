using System;
using DataAccess;
using Module;
namespace ACM_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ACMContext())
            {
                var tenant = new User() {  };
                context.Tenants.Add(tenant);
                context.SaveChanges();
            }

            Console.WriteLine("after Update data");

            using (var context = new ACMContext())
            {
                var tenants = context.Tenants;
                foreach(var item in tenants)
                {
                    Console.WriteLine(item.TenantName);
                }
            }
        }
    }
}
