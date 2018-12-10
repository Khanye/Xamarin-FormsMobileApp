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
	public partial class SubmitUserProfile : ContentPage
	{
	  
        public SubmitUserProfile ()
        {

            Title = "Create Profile";
            NavigationPage.SetTitleIcon(this, "Icon.png");

			InitializeComponent ();

           
            GenderPicker.Items.Add("Male");
		    GenderPicker.Items.Add("Female");


		    QualificationPicker.Items.Add("High School Student");
		    QualificationPicker.Items.Add("Tertiary Student");
		    QualificationPicker.Items.Add("Young Professional");
		    QualificationPicker.Items.Add("Other");

		    CoursePicker.Items.Add("Information Systems");
		    CoursePicker.Items.Add("Telecommunications");
		    CoursePicker.Items.Add("Media Studies");
		    CoursePicker.Items.Add("Human Resources Management");


		    FieldsofinterestPicker.Items.Add("General Management");
		    FieldsofinterestPicker.Items.Add("Media; Advertising;PR; Publishing & Marketing");
		    FieldsofinterestPicker.Items.Add("Administration, Office Support And Services");
		    FieldsofinterestPicker.Items.Add("Construction; Design; Architecture & Property");
		    FieldsofinterestPicker.Items.Add("Banking & Finance; Insurance & Broking");
		    FieldsofinterestPicker.Items.Add("SHEQ and Security");
		    FieldsofinterestPicker.Items.Add("Textile and Clothing");
		    FieldsofinterestPicker.Items.Add("Engineering, Technical, Production & Manufacturing");
		    FieldsofinterestPicker.Items.Add("Health; Fitness and Medical ");
		    FieldsofinterestPicker.Items.Add("Legal");
		    FieldsofinterestPicker.Items.Add("Government & NGO");
		    FieldsofinterestPicker.Items.Add("RD Science & Scientific Research ");
		    FieldsofinterestPicker.Items.Add("Human Resources & Recruitment");
		    FieldsofinterestPicker.Items.Add("Chemical; Petroleum ; Oil & Gas");
		    FieldsofinterestPicker.Items.Add("Accounting; Auditing ");
		    FieldsofinterestPicker.Items.Add("Transport & Logistics;Freight");
		    FieldsofinterestPicker.Items.Add("Retail ; Supply Chain & Wholesale");
		    FieldsofinterestPicker.Items.Add("Sales and Purchasing");
		    FieldsofinterestPicker.Items.Add("Hospitality; Hotel & Catering; Tourism & Travel");
		    FieldsofinterestPicker.Items.Add("Agriculture & Forestry; Environment & Fishing");
		    FieldsofinterestPicker.Items.Add("Education and Training");
		    FieldsofinterestPicker.Items.Add("IT and Telecommunications");
		    FieldsofinterestPicker.Items.Add("Graduate ; NO Experience");
		    FieldsofinterestPicker.Items.Add("Others");


        }

        

        private void GenderPicker_OnSelectedIndexChanged(object sender, EventArgs e)
	    {
	      
	    }




	}
}