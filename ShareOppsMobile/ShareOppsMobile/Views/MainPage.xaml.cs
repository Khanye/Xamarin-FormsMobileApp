using ShareOppsMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareOppsMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareOppsMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new SubmitOppotunity());
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
           var oppotunity = e.Item as Oppotunity;

          await Navigation.PushAsync(new ApprovePage(oppotunity));
        }
    }
}
 