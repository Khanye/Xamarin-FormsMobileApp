using ShareOppsMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareOppsMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SavedOppotunities : ContentPage
	{
		public SavedOppotunities ()
		{
			InitializeComponent ();
		}

	    private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var oppotunity = e.Item as Oppotunity;

	        Navigation.PushAsync(new ApprovePage(oppotunity));
	    }
    }
}