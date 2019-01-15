using Model.UserModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            client = new HttpClient();
          
            //var content = response.Content.ReadAsStringAsync().Result;
          //  userData = JsonConvert.DeserializeObject<List<User>>(content);



        }

        HttpClient client;

        List<Model.UserModel.User> userData;


        private async void LogInClicked(object sender, EventArgs e)
        {
            for (int i = 5; i < 9; i++)
            {
                try
                {
                    var response = client.GetAsync($"http://192.168.1.198:4545{i}/api/Identity/all").Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    userData = JsonConvert.DeserializeObject<List<User>>(content);
                    break;
                }
                catch
                {
                   
                }
            }
          
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
