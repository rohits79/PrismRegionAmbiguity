using System.Windows;

namespace RegionIssue
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var bootStrapper = new BootStrapper();
            bootStrapper.Run();
        }
    }
}
