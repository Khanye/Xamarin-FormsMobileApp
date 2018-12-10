using ShareOppsMobile.Models;
using ShareOppsMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ShareOppsMobile.Views;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
    public class SubmitViewModel
    {
        private DataService dataService = new DataService();
        public Oppotunity SelectedOppotunity { get; set; }

        public ICommand Submit => new Command(async () =>
        {
            SelectedOppotunity.IsApproved = false;

            var isRegistered = await dataService.PostOppotunity(SelectedOppotunity);

            if (isRegistered)

            {

                
                await Application.Current.MainPage.DisplayAlert("ShareOpps", "Oppotunity Successfully submitted", "Ok");
                //DependencyService.Get<Toast>().Show("You have registered succefully");
                Application.Current.MainPage = new NavigationPage(new SubmitOppotunity());
            }

            else
            {
                await Application.Current.MainPage.DisplayAlert("ShareOpps", "Error Please try again later", "Ok");
                
                Application.Current.MainPage = new NavigationPage(new SubmitOppotunity());
            }


        });

        public SubmitViewModel()
        {
            SelectedOppotunity = new Oppotunity();


        }
    }
}
