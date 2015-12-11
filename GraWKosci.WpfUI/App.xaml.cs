using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using GraWKosci.WpfUI.StartApp;
using GraWKosci.WpfUI.View;
using GraWKosci.WpfUI.ViewModel;

namespace GraWKosci.WpfUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            var bootstrapper = new Bootstrapper();
            IContainer container = bootstrapper.Bootstrap();
            var mainViewModel = container.Resolve<MainViewModel>();
            MainWindow = new MainWindow(mainViewModel);
            MainWindow.Show();
        }
    }
}
