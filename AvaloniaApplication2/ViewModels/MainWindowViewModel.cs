using AvaloniaApplication2.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IServiceProvider Provider;
        public MainWindowViewModel(IServiceProvider provider)
        {
            Provider = provider;
        }

        public void OnClickCommand()
        {
            Provider.GetRequiredService<Dialog>().Show();
        }
        public string Greeting => "Welcome to Avalonia!";
    }
}
