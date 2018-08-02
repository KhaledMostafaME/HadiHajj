using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HadiHajj
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void btn_login_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }

        private void btn_signup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());

        }
    }
}