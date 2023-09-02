using System;
using System.ServiceModel;
using System.Threading;
using Autofac;
using Autofac.Integration.Wcf;
using WcfTestProject.Interface_Implementations;
using WcfTestProject.Interfaces;
using WcfTestProject.Model;

// service library

namespace EmailProServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<AdminService>().SingleInstance();
            builder.RegisterType<UserService>();
            builder.RegisterType<GeneralService>();
            builder.RegisterType<EmailPro>().InstancePerLifetimeScope();

            var container = builder.Build();
           
            AutofacHostFactory.Container = container;
            var factory = new AutofacServiceHostFactory();
            var assemblyQualifiedName = typeof(AdminService).AssemblyQualifiedName;
            if (assemblyQualifiedName != null)
            {
                var adminService = factory.CreateServiceHost(assemblyQualifiedName, Array.Empty<Uri>());
                //adminService.Open();
            }

            var constructorString = typeof(UserService).AssemblyQualifiedName;
            if (constructorString != null)
            {
                var userService = factory.CreateServiceHost(constructorString, Array.Empty<Uri>());
                userService.Open();
            }

            var qualifiedName = typeof(GeneralService).AssemblyQualifiedName;
            if (qualifiedName != null)
            {
                var generalService = factory.CreateServiceHost(qualifiedName, Array.Empty<Uri>());
                generalService.Open();
            }

            var adminServiceFactory = new ChannelFactory<IAdminService>("*");
            IAdminService admin = null;

            try
            {
                admin = adminServiceFactory.CreateChannel();

                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("System users:");
                    foreach (var user in admin.GetAllUsers())
                        Console.WriteLine($"{user.Username}");
                }
            }
            finally
            {
                if (admin is IClientChannel clientChannel)
                {
                    try
                    {
                        if (clientChannel.State != CommunicationState.Faulted)
                        {
                            clientChannel.Close();
                        }
                    }
                    catch
                    {
                        clientChannel.Abort();
                    }
                }
            }
        }
    }
}
