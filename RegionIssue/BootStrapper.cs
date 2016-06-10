using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;

namespace RegionIssue
{
    public class BootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            App.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @".\DirectoryModules" };
        }
    }
}
