using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfStudy.WPF;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        Window window = new WPF.MainWindow();
        window.Show();
    }
}
