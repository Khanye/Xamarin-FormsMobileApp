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
	public partial class NewRegisterPage : ContentPage
	{
		public NewRegisterPage ()
		{
			InitializeComponent ();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new Login());
	    }
	}
}