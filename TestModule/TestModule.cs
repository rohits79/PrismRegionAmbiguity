using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace TestModule
{
    public class TestModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer unityContainer;

        public TestModule(IRegionManager regionManager, IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.unityContainer = unityContainer;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("ViewB", typeof(ViewB));

            // Uncomment the following three lines and we get exception, this gets fixed with scoped region
             var region = regionManager.Regions["ViewA"];
             region.Add(unityContainer.Resolve<ViewA>());
             region.Add(unityContainer.Resolve<ViewA>());

            // the following works
            // regionManager.AddToRegion("ViewA", unityContainer.Resolve<ViewA>());
            // regionManager.AddToRegion("ViewA", unityContainer.Resolve<ViewA>());
        }
    }
}
