using ShareOppsMobile.Models;
using ShareOppsMobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
    

        public class SavedOppDetailsViewModel
        {
            private DataService dataService = new DataService();
            public Oppotunity SelectedOppotunity { get; set; }

            

            public SavedOppDetailsViewModel()
            {
                SelectedOppotunity = new Oppotunity();
            }

        }
    
}
