using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace QuickstartApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuickstartApp.MainPage();
        }

        protected override void OnStart()
        {
            /* 
             * Start Mobile Center SDK
             * Remember to replace {IOS_APP_SECRET} and {ANDROID_APP_SECRET} with your actual app secrets
             */
            MobileCenter.Start("ios={IOS_APP_SECRET};android={ANDROID_APP_SECRET}", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
