using ShareOppsMobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SearchPage = ShareOppsMobile.Views.SearchPage;

namespace ShareOppsMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPageMaster : ContentPage
    {
        public ListView ListView;

        public EntryPageMaster()
        {
            InitializeComponent();

            BindingContext = new EntryPageMasterViewModel();
            ListView = MenuItemsListView;
        }

       public class EntryPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<EntryPageMenuItem> MenuItems { get; set; }
            
            public EntryPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<EntryPageMenuItem>(new[]
                {
                    new EntryPageMenuItem { Id = 0, Title = "All Opportunities" , Icon ="AllOpp.png" ,TargetType = typeof(MainPage)},
                    new EntryPageMenuItem { Id = 1, Title = "Categories", Icon ="Category.png",TargetType = typeof(Categories)},
                    new EntryPageMenuItem { Id = 2, Title = "My Opportunities" , Icon ="SavedOpp.png",TargetType = typeof(SavedOppotunities)},
                    new EntryPageMenuItem { Id = 3, Title = "Submit An Opportunity", Icon ="Submit.png", TargetType = typeof(SubmitOppotunity)},
                    new EntryPageMenuItem { Id = 4, Title = "Notifications" , Icon ="Notifications.png", TargetType = typeof(NotificationsPage)},
                    new EntryPageMenuItem { Id = 5, Title = "My Profile", Icon = "Policy.png" , TargetType = typeof(SubmitUserProfile)},
                    new EntryPageMenuItem { Id = 6, Title = "Search", Icon ="Search.png" ,TargetType = typeof(SearchPage)},
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}