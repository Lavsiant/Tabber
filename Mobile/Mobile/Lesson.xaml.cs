using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
	public partial class Lesson : ContentPage
	{
		public Lesson ()
		{
			InitializeComponent ();
		}

        public Lesson(User user,Course course)
        {
            InitializeComponent();
            User = user;
            Course = course;
            TabList = new List<Tab>();
            foreach (var item in course.Lessons)
            {
                TabList.Add(item.Tab);
            }
            this.BindingContext = this;
            Header = $"Course '{course.Name}' items:";
        }

        public string Header { get; set; }

        public User User { get; set; }

        public Course Course { get; set; }

        public List<Tab> TabList { get; set; }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Course selectedCourse = e.Item as Course;
            if (selectedCourse != null)
            {
                await DisplayAlert("Success", "Lesson was uploaded to 'Smart Tabber", "OK");
            }
                
        }

        private void Back(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Courses(User);
        }
    }
}