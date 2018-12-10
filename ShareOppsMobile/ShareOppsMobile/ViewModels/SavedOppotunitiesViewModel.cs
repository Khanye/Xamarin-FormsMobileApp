using ShareOppsMobile.Models;
using ShareOppsMobile.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShareOppsMobile.Annotations;
using ShareOppsMobile.Helpers;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
   public  class SavedOppotunitiesViewModel : INotifyPropertyChanged
    {

        private List<SavedOppotunities> _savedOppotunities;
        private DataService dataService = new DataService();
        private bool _isRefreshing;
        //public string AccessToken { get; set; }

        public List<SavedOppotunities> SavedOppotunities
        {
            get { return _savedOppotunities; }
            set
            {
                _savedOppotunities = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        //Refresh List Items
        public ICommand RefreshCommand => new Command(async () =>
        {
            await GetSavedOppotunities();
        });



        public SavedOppotunitiesViewModel()
        {
            GetSavedOppotunities();

        }
        private async Task GetSavedOppotunities()
        {
            IsRefreshing = true;
            var AccessToken = Settings.AccessToken;
            SavedOppotunities = await dataService.GetSavedOppForUserAsync(AccessToken );
            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged; 

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
    