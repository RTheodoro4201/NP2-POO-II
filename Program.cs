using System;
using System.Data;
using System.Windows.Forms;
using Autofac;
using MySqlConnector;
using POO_II_NP2_WinForms.Controller;
using POO_II_NP2_WinForms.Model;
using POO_II_NP2_WinForms.Repository;
using POO_II_NP2_WinForms.View;

namespace POO_II_NP2_WinForms;

    static class Program
    {
        private const string ConnectionString =
            @"Server=localhost;Port=3306;Database=poo_ii_np2;User=root;Password=";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.Register(_ => new MySqlConnection(ConnectionString)).As<IDbConnection>().InstancePerLifetimeScope();
            builder.RegisterType<LivroRepository>().As<IRepository<Livro>>().InstancePerLifetimeScope();
            builder.RegisterType<LivroController>();
            builder.RegisterType<LivroForm>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var scope = container.BeginLifetimeScope();
            var form = scope.Resolve<LivroForm>();
            Application.Run(form);
        }
    }