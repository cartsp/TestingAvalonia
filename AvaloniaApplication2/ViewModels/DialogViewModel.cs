using AvaloniaApplication2.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.ViewModels
{
    public class DialogViewModel : ViewModelBase
    {
        private readonly IServiceProvider Provider;
        public DialogViewModel(IServiceProvider provider)
        {
            Provider = provider;
        }

        public async Task OnClickCommand()
        {
            string t = "";
            await Task.Run(() => t = "fgh");
            new Dialog().Show();
            //var dialog = Provider.GetRequiredService<Dialog>();
            //dialog.Show();
            // do something
        }
        public string Greeting => "Welcome to Avalonia!";
    }
}
