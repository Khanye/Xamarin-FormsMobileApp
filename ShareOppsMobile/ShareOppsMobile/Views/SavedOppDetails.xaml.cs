using ShareOppsMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareOppsMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShareOppsMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SavedOppDetails : ContentPage
	{
	    public SavedOppDetails(Oppotunity oppotunity)
	    {

	        var approveViewModel = new ApproveViewModel();
	        approveViewModel.SelectedOppotunity = oppotunity;

	        BindingContext = approveViewModel;

	        InitializeComponent();


	    }
    }
}