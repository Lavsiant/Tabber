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
	public partial class Courses : ContentPage
	{
		public Courses ()
		{
			InitializeComponent ();
		}

        public Courses(User user)
        {
            InitializeComponent();
            this.user = user;
            Header = $"{user.UserName}'s bought courses";
            CourseList = this.user.Courses;
            this.BindingContext = this;
        }

        User user = new User();

        public List<Course> CourseList { get; set; }

        public string Header { get; set; }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Course selectedCourse = e.Item as Course;
            if (selectedCourse != null)
                Application.Current.MainPage = new Lesson(user,selectedCourse);
        }

        private  void LogOut(object sender, EventArgs e)
        {

            Application.Current.MainPage = new MainPage();
         
        }
    }
}