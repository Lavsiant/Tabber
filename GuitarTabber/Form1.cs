using Model.GuitarTab;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarTabber
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();
            _indexOfLastIteration = 0;
            _testTab = new Tab()
            {
                Creator = "Me",
                Tempo = 60,
                Iterations = new List<TabIteration>()
                {
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=1},
                            new Note() {StringNumber=5, Fret=1}
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=1, Fret=1},
                            new Note() {StringNumber=3, Fret=2},
                            new Note() {StringNumber=4, Fret=3},
                            new Note() {StringNumber=5, Fret=3},
                            new Note() {StringNumber=6, Fret=1},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=2},
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=4, Fret=0}
                        }
                    },
                     new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=1},
                            new Note() {StringNumber=5, Fret=1}
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=1, Fret=1},
                            new Note() {StringNumber=3, Fret=2},
                            new Note() {StringNumber=4, Fret=3},
                            new Note() {StringNumber=5, Fret=3},
                            new Note() {StringNumber=6, Fret=1},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=2},
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=4, Fret=0}
                        }
                    }, new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=1},
                            new Note() {StringNumber=5, Fret=1}
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=1, Fret=1},
                            new Note() {StringNumber=3, Fret=2},
                            new Note() {StringNumber=4, Fret=3},
                            new Note() {StringNumber=5, Fret=3},
                            new Note() {StringNumber=6, Fret=1},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=2},
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=4, Fret=0}
                        }
                    },
                }
            };
            var data = new Data();
            tabs = data.GetAllTabs();
            //currentTab = tabs.First();
          
            tempoSlowK.Value = 100;

            var activeCourse = new Model.GuitarTab.ActiveCourse();
            var client = new HttpClient();
            for (int i = 5; i <= 8; i++)
            {
                try
                {
                    var response = client.GetAsync($"http://192.168.4.39:4545{i}/api/Course/get-activated-course").Result;
                    var content = response.Content.ReadAsStringAsync().Result;
                    activeCourse = JsonConvert.DeserializeObject<ActiveCourse>(content);

                    response = client.GetAsync($"http://192.168.4.39:4545{i}/api/Course/course?id=" + activeCourse.CourseId).Result;
                    content = response.Content.ReadAsStringAsync().Result;
                    course = JsonConvert.DeserializeObject<Course>(content);
                    break;
                }
                catch
                {

                }
            }
         

            currentLesson = course.Lessons.FirstOrDefault();
            progress_bar.Maximum = currentLesson.Tab.Iterations.Count - 1;
            NameLabel.Text = currentLesson.Name;



        }

        private readonly Tab _testTab;
        private int _indexOfLastIteration;
        private CancellationTokenSource _cts;
        private List<Tab> tabs;
        private Tab cursrentTab;
        private Lesson currentLesson;
        private Course course;
        private List<Lesson> lessons;


        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            _cts = new CancellationTokenSource();
            this.Update();
            var task = new Task(() => StartTabReading(_cts.Token, this, _indexOfLastIteration), _cts.Token);
            task.Start();
        }

        private void StartTabReading(CancellationToken ct, Form form, int startIndex)
        {
            for (int i = startIndex; i < currentLesson.Tab.Iterations.Count; i++)
            {
                
                if (!ct.IsCancellationRequested)
                {
                    this.InvokeEx(f => f.progress_bar.Value = i);

                    foreach (var note in currentLesson.Tab.Iterations[i].ActiveNotes)
                    {
                        var bt = form.Controls.Find($"note_{note.StringNumber}_{note.Fret}", true).First();
                        this.InvokeEx(f => bt.Visible = true);

                    }
                    this.InvokeEx(f => f.Update());
                    Thread.Sleep(Convert.ToInt32((currentLesson.Tab.Tempo * currentLesson.Tab.Iterations[i].WaitTimeScalar)* 5/100 * Convert.ToInt32(tempoSlowK.Value)));



                    foreach (var note in currentLesson.Tab.Iterations[i].ActiveNotes)
                    {
                        var bt = form.Controls.Find($"note_{note.StringNumber}_{note.Fret}", true).First();
                        this.InvokeEx(f => bt.Visible = false);
                    }
                    this.InvokeEx(f => f.Update());
                    _indexOfLastIteration = i;
                }
                else
                {
                    _indexOfLastIteration = i;
                    this.InvokeEx(f => f.start_button.Enabled = true);
                    this.InvokeEx(f => f.Update());
                    ct.ThrowIfCancellationRequested();
                    break;
                }

                this.InvokeEx(f => f.Update());
            }
            this.InvokeEx(f => f.start_button.Enabled = true);
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            start_button.Enabled = true;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            _indexOfLastIteration = 0;
            progress_bar.Value = 0;
        }

        private void progress_bar_Scroll(object sender, EventArgs e)
        {
            _cts.Cancel();
            start_button.Enabled = true;
            _indexOfLastIteration = progress_bar.Value;
          
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            start_button.Enabled = true;
            var indx = course.Lessons.FindIndex(x => x == currentLesson);
            if(indx+1 == course.Lessons.Count)
            {
                currentLesson = course.Lessons.First();
            }
            else
            {
                currentLesson = course.Lessons[indx+1];
            }
            NameLabel.Text = currentLesson.Name;
            progress_bar.Maximum = currentLesson.Tab.Iterations.Count - 1;
            progress_bar.Value = 0;
            _indexOfLastIteration = progress_bar.Value;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            start_button.Enabled = true;
            var indx = course.Lessons.FindIndex(x => x == currentLesson);
            if (indx - 1 < 0)
            {
                currentLesson = course.Lessons.Last();
            }
            else
            {
                currentLesson = course.Lessons[indx];
            }
            NameLabel.Text = currentLesson.Name;
            progress_bar.Maximum = currentLesson.Tab.Iterations.Count - 1;
            progress_bar.Value = 0;
            _indexOfLastIteration = progress_bar.Value;
        }
    }

}
