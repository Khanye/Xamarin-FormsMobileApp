using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
//using ShareOppsMobile.Helpers;
using ShareOppsMobile.Models;
using ShareOppsMobile.Services;
using Xamarin.Forms;

namespace ShareOppsMobile.ViewModels
{
    public class ByCategoryViewModel : INotifyPropertyChanged
    {
        private DataService dataService = new DataService();
        private List<Oppotunity> _bycategoryoppotunities;
        private string _keyword;

        public string Keyword
        {
            get { return _keyword; }
            set
            {
                _keyword = value;
                OnPropertyChanged();
            }
        }

        public List<Oppotunity> ByCategoryOppotunities
        {
            get { return _bycategoryoppotunities; }
            set
            {
                _bycategoryoppotunities = value;
                OnPropertyChanged();
            }
        }


        public Oppotunity SelectedOppotunity { get; set; }

        //public ICommand SaveCommand => new Command(async () =>
        //{
        //    await dataService.PostSaveOppotunity(SelectedOppotunity);
        //});


        public ICommand SearchCommand
        {
            get
            {
                return new Command(async () =>
                {
                    ByCategoryOppotunities = await dataService.GetByKeywordAsync(_keyword);
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
