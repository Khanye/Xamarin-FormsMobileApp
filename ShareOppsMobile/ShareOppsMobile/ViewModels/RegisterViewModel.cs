using ShareOppsMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ShareOppsMobile.Helpers;
using ShareOppsMobile.Views;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
    public class RegisterViewModel
    {
        private readonly DataService dataService = new DataService();
        public string Email  { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Message { get; set; }
        

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>

                {
                    var isRegistered = await dataService.RegisterUserAsync(Email, Password, ConfirmPassword);

                    Settings.Username = Email;
                    Settings.Password = Password;
                    

                    if (isRegistered)

                    {
                       
                        //DisplayAlert( "Alert" , "Registered", "OK");
                        Message = "Registered Successfully :)";
                        await Application.Current.MainPage.DisplayAlert("ShareOpps","You have been registered successfully","Ok");
                        //DependencyService.Get<Toast>().Show("You have registered succefully");
                        Application.Current.MainPage = new NavigationPage(new Login());
                    }

                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("ShareOpps", "Registration Error. Please try again later", "Ok");
                        Application.Current.MainPage = new NavigationPage(new NewRegisterPage());
                    }

                    
                      
                    
                });
            }
        }
    }
}
