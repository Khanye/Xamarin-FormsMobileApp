using ShareOppsMobile.Views;
using System;
using ShareOppsMobile.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ShareOppsMobile
{
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
           // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDQwNzNAMzEzNjJlMzMyZTMwR2oyWW1jbUFIV29HeFY4ZTRCSlZUUTJRbXpsOEUvODN1blFoVXZWQXFqOD0=");
            InitializeComponent();

            //MainPage = new NavigationPage(new SubmitOppotunity ());

            //MainPage = new NavigationPage(new EntryPage());
            //MainPage = new NavigationPage(new UserProfile ());
            // MainPage = new NavigationPage(new NewRegisterPage() );
            //SetMainPage();
            MainPage = new NavigationPage(new SubmitUserProfile ())

            {
                BarBackgroundColor= Color.Firebrick ,
                BarTextColor = Color.White 
            };

            //MainPage = new NavigationPage(new SplashPage());
        }

        private void SetMainPage()
        {
            if (!string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainPage = new NavigationPage(new EntryPage());
            }

            //else if (!string.IsNullOrEmpty(Settings.Username) &&
            //         !string.IsNullOrEmpty(Settings.Password))
            //{
            //    MainPage = new NavigationPage(new Login());
            //}

            else
            {
                MainPage = new NavigationPage(new SplashPage());
            }


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
