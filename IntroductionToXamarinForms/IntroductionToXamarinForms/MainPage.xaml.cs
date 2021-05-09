using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntroductionToXamarinForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            var sl = new StackLayout
            {
                Spacing = 15,
                Margin = new Thickness(15, 120, 15, 15)
            };

            sl.Children.Add(new Label{ Text = "Email application" });

            Content = sl;
        }
    }
}
