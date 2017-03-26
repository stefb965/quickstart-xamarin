using System;
using Xamarin.Forms;
using Microsoft.Azure.Mobile.Crashes;

namespace QuickstartApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCrashMeButtonClicked(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }
    }
}
