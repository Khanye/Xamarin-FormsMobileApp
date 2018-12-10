using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ShareOppsMobile.Helpers;
//using ShareOppsMobile.Helpers;
using ShareOppsMobile.Models;
using ShareOppsMobile.Services;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
    public class SearchViewModel : INotifyPropertyChanged
    {
        private DataService dataService = new DataService();
        private List<Oppotunity> _searchedoppotunities;
        private string _keyword;

        public string Keyword
        {
            get {return _keyword;}
            set
            {
                _keyword = value;
                OnPropertyChanged();
            }
        }

        public List<Oppotunity > SearchedOppotunities 
        {
            get { return _searchedoppotunities; }
            set
            {
                _searchedoppotunities = value;
                OnPropertyChanged();
            }
        }


        public Oppotunity SelectedOppotunity { get; set; }

        public ICommand SaveCommand => new Command(async () =>
        {
            await dataService.PostSaveOppotunity(SelectedOppotunity, Settings.AccessToken);
        });


        public ICommand SearchCommand
        {
            get
            {
                return new Command(async () =>
                {
                    SearchedOppotunities = await dataService.GetByKeywordAsync(_keyword);
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}