using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Label_Button_Entry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUsingCSharp 
    {
        public LoginUsingCSharp()
        {
            //InitializeComponent();

            this.BackgroundColor = Color.Azure;
            var lblUserName = new Label { Text = "UserName", TextColor = Color.Black };
            var entryUserName = new Entry { Placeholder = "Enter User Name" };
            var lblPassword = new Label { Text = "Password", TextColor = Color.Black };
            var entryPassword = new Entry { Placeholder = "Enter Password", IsPassword = true };
            var btnLogin = new Button { Text = "Login", BackgroundColor = Color.Yellow };
            btnLogin.Clicked += LoginEvent;

            this.Content = new StackLayout
            {
                Padding = new Thickness(20),
                Margin = new Thickness(0, 80, 0, 0),
                Children =
                {
                    lblUserName, entryUserName, lblPassword, entryPassword, btnLogin
                }
            };
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Sucessfull", "Ok");
        }
    }
}