using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lesson : ContentPage
	{
        public Lesson()
        {
            InitializeComponent();
        }

        public Lesson(User user, Course course)
        {
            InitializeComponent();
            User = user;
            Course = course;
            TabList = new List<Model.GuitarTab.Lesson>();
            foreach (var item in course.Lessons)
            {
                TabList.Add(item);
            }
            Header = $"Course '{course.Name}' items:";
            IsAdmin = user.UserName == "admin" ? true : false;
            this.BindingContext = this;
  
        }

        public bool IsAdmin { get; set; }

        public string Header { get; set; }

        public User User { get; set; }

        public Course Course { get; set; }

        public List<Model.GuitarTab.Lesson> TabList { get; set; }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Model.GuitarTab.Lesson selectedCourse = e.Item as Model.GuitarTab.Lesson;
            var client = new HttpClient();
            var counter = 0;
            foreach (var lesson in Course.Lessons)
            {
                if(lesson.ID == selectedCourse.ID)
                {
                    break;
                }
                counter++;
            }
            var response = client.GetAsync("http://192.168.1.5:45455/api/Course/course-activate?id=" + Course.ID+"&index="+ counter).Result;
            await DisplayAlert("Success", "Lesson" +selectedCourse.Name +" was uploaded to 'Smart Tabber", "OK");
        }

        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Courses(User);
        }
        

        public void DeleteCourse(object sender, EventArgs e)
        {
            User.Courses.Remove(Course);
            Application.Current.MainPage = new Courses(User);
        }
    }
}
