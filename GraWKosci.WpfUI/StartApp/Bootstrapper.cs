using Autofac;

namespace GraWKosci.WpfUI.StartApp {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();



            return builder.Build();
        }
    }
}