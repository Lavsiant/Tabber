using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Login";
            InitializeComponent();
            userData = new UserData().GetUsers();
        }

        List<Model.UserModel.User> userData;


        private async void LogInClicked(object sender, EventArgs e)
        {
            var user = userData.FirstOrDefault(x => x.UserName.Equals(this.Login.Text) && x.Password.Equals(this.Password.Text));
            if (user != null)
            {
                Application.Current.MainPage = new Courses(user);
            }
            else
            {
                await DisplayAlert("Alert", "Incorrect login or password", "OK");
            }
        }

    }
}
