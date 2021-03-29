using Prism;
using Prism.Ioc;
using PublishApp.ViewModels;
using PublishApp.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Microsoft.AppCenter.Distribute;

namespace PublishApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnStart()
        {
            base.OnStart();
            AppCenter.Start("android=c25a14bc-de20-4feb-82b8-1ff7e2c05e3a;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",typeof(Distribute));
        }
    }
}
