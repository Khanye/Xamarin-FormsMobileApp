using ShareOppsMobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShareOppsMobile.Annotations;
using ShareOppsMobile.Services;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
   public class MainViewModel: INotifyPropertyChanged 
    {
        private List<Oppotunity> _oppotunities;
        private DataService dataService = new DataService();
        private bool _isRefreshing;



       

        public List<Oppotunity> Oppotunities
        {
            get { return _oppotunities; }
            set
            {
                _oppotunities = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;}
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        //Refresh List Items
        public ICommand RefreshCommand => new Command(async () =>
        {
            await GetOppotunities();
        });



        public MainViewModel()
        {
            GetOppotunities();
           
        }
      private  async Task GetOppotunities()
      {
          IsRefreshing = true;
            Oppotunities = await dataService.GeOppotunities();
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
