using Plugin.Multilingual;
using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiLanguageApp
{
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            //CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            InitializeComponent();
            var culture = CrossMultilingual.Current.DeviceCultureInfo;
            AppResources.Culture = culture;
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
