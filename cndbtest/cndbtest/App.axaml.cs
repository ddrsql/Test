using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using cndbtest.ViewModels;
using cndbtest.Views;

namespace cndbtest
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
        /// <summary>
        /// override RegisterServices register custom service
        /// </summary>
        public override void RegisterServices()
        {
            AvaloniaLocator.CurrentMutable.Bind<IFontManagerImpl>().ToConstant(new CustomFontManagerImpl());
            base.RegisterServices();
        }
    }
}
