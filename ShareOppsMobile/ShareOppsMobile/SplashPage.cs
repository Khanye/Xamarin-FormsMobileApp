using System;
using System.Collections.Generic;
using System.Text;
using ShareOppsMobile.Views;
using Xamarin.Forms;

namespace ShareOppsMobile
{
    public class SplashPage: ContentPage
    {
        Image splashImage;
        Label Label;
        

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
           

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "ShareOppsIcon.jpg",
                WidthRequest = 100,
                HeightRequest = 100
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
            new Rectangle (0.5,0.5, AbsoluteLayout.AutoSize , AbsoluteLayout.AutoSize));


            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.White ;
            this.Content = sub;

            Label = new Label
            {
                Text = " ShareOpps: We share oppotunities!!!" ,
                TextColor = Color.Firebrick ,
                FontSize = 24,
                
                
                 
            };

        }

        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 5000);
            await splashImage.ScaleTo(0.9, 1500 , Easing.Linear );
            await splashImage.ScaleTo(150, 2000, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new NewRegisterPage());


        }


    }
}
