using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication2.ViewModels;
using AvaloniaApplication2.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AvaloniaApplication2
{
    public class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                //var builder = new ConfigurationBuilder();

                //Configuration = builder.Build();

                var serviceCollection = new ServiceCollection();
                ConfigureServices(serviceCollection);

                ServiceProvider = serviceCollection.BuildServiceProvider();

                desktop.MainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            };

            base.OnFrameworkInitializationCompleted();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(sp => sp);
            services.AddTransient(typeof(Dialog));
            services.AddTransient(typeof(MainWindow));
            services.AddTransient(typeof(MainWindowViewModel));
        }
    }
}
