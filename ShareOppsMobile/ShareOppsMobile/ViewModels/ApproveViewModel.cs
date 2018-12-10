using ShareOppsMobile.Models;
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
    public class ApproveViewModel
    {
        private DataService dataService = new DataService();
        public Oppotunity SelectedOppotunity { get; set; }


        public ICommand SaveCommand => new Command(async () =>
            { 
            
            await dataService.PostSaveOppotunity(SelectedOppotunity, Settings.AccessToken);
                   
            });

        public ApproveViewModel()
        {
            SelectedOppotunity = new Oppotunity();
        }

    }
}
