using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication2.ViewModels;
using ReactiveUI;
using System.Threading.Tasks;

namespace AvaloniaApplication2.Views
{
    public class MainWindow : Window
    {
        public MainWindowViewModel vm { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(MainWindowViewModel viewmodel)
        {
            vm = viewmodel;
            this.DataContext = vm;
            InitializeComponent();

            //OnClickCommand = ReactiveCommand.Create(() => {
            //    string t = "";
            //    var b = Task.Run(() => t = "fgh").Result;/* do something */
            //});
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


    }
}
