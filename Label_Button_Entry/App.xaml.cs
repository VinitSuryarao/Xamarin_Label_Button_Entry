using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Label_Button_Entry
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginUsingCSharp();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
