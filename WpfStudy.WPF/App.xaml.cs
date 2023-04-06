using System.Windows;

namespace WpfStudy.WPF;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        Window window = new MainWindow();
        window.Show();
    }
}