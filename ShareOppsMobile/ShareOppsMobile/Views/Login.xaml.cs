using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareOppsMobile.Views
{
	
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

	    //public ICommand RegisterCommand => new Command(async () =>
	    //{
	    //   await Navigation.PushAsync(new RegisterPage());
	    //});

	    

	    //private void Button_OnClicked(object sender, EventArgs e)
	    //{
	    //    Navigation.PushAsync(new EntryPage() );
     //   }

	    

	    private void Register_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new NewRegisterPage());
        }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushModalAsync(new SavedOppotunities());
	    }
	}
} 