using Autofac;
using GraWKosci.WpfUI.View.Services;
using GraWKosci.WpfUI.ViewModel;

namespace GraWKosci.WpfUI.StartApp {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();
            builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();
            builder.RegisterType<GameTabViewModel>().As<ITabViewModel>();
            builder.RegisterType<MainViewModel>().AsSelf();
            

            return builder.Build();
        }
    }
}