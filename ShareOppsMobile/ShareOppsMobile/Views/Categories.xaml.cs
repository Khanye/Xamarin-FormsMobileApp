using ShareOppsMobile.Services;
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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Categories : ContentPage
	{   
        public string Keyword { get; set; }
		public Categories ()
		{
			InitializeComponent ();

		    SetEvent();
		}

        void SetEvent()
        {
            ImageIct.GestureRecognizers.Add(new TapGestureRecognizer
            {
               

            });
        }
    }

    


}