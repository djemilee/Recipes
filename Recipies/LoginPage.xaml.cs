using System;
using Xamarin.Forms;

namespace Recipies
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                await DisplayAlert("Error", "User Name is Required", "OK");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                await DisplayAlert("Error", "Password is Required", "OK");
                return;
            }

            if (!txtUsername.Text.ToString().Trim().Equals("admin") || !txtPassword.Text.ToString().Trim().Equals("admin"))
            {
                await DisplayAlert("Error", "Incorrect Username / Password. Please Try Again.", "OK");
                return;
            }

            bool isValidUser = true; 

            if (isValidUser)
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Login Failed", "Invalid email or password. Please try again.", "OK");
            }
        }
    }
}
