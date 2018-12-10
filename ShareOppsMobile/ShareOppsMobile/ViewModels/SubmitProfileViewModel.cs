using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ShareOppsMobile.Models;
using ShareOppsMobile.Services;
using ShareOppsMobile.Views;
using UserProfile = ShareOppsMobile.Models.UserProfile;

namespace ShareOppsMobile.ViewModels
{
    public class SubmitProfileViewModel
    {

        
        
            private DataService dataService = new DataService();
            public UserProfile SelectedUserProfile { get; set; }

            public ICommand SubmitProfileCommand => new Xamarin.Forms.Command(async () =>
            {
                //SelectedUserProfile.IsApproved = false;
                //SelectedUserProfile.CategoryID = 1;
                await dataService.PostUserProfile(SelectedUserProfile);


            });

            public SubmitProfileViewModel()
            {
                SelectedUserProfile = new UserProfile();


            }
        
    }
}
