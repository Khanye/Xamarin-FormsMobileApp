using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ShareOppsMobile.Helpers;
using ShareOppsMobile.Services;
using ShareOppsMobile.Views;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
   public class LoginViewModel
    {
        private DataService dataService = new DataService();
        public string  Username { get; set; }
        public string Password { get; set; }

        

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>

                {
                    var accesstoken = await dataService.LoginAsync(Username ,Password );
                    Application.Current.MainPage = new NavigationPage(new EntryPage());

                    Settings.AccessToken = accesstoken;

                    if (!string.IsNullOrEmpty(accesstoken))
                    {
                        Application.Current.MainPage = new NavigationPage(new EntryPage());
                    }

                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("ShareOpps", "Login Error", "Ok");
                        //DependencyService.Get<Toast>().Show("You have registered succefully");
                        Application.Current.MainPage = new NavigationPage(new Login());

                    }

                });
            }
        }

        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }

        


    }
}
