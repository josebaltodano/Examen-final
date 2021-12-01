using AppCore.Interface;
using AppCore.Services;
using Autofac;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examenfinal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EstudianteModel>().As<IEstudiante>();
            builder.RegisterType<EstudianteService>().As<Iestudianteservices>();
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<Iestudianteservices>()));
        }
    }
}
