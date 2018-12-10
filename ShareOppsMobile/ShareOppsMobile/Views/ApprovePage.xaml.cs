 using ShareOppsMobile.Models;
using ShareOppsMobile.ViewModels;
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
	public partial class ApprovePage : ContentPage
	{
		public ApprovePage (Oppotunity oppotunity )
		{

		    var approveViewModel = new ApproveViewModel() ;
		    approveViewModel.SelectedOppotunity = oppotunity;

		    BindingContext = approveViewModel;

			InitializeComponent ();
		     

		  }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        
	    }
	}
}