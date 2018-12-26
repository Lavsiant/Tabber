using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            currentTab = tabs.First();
            progress_bar.Maximum = currentTab.Iterations.Count-1;
            NameLabel.Text = currentTab.Name;
            tempoSlowK.Value = 100;
        }

        private readonly Tab _testTab;
        private int _indexOfLastIteration;
        private CancellationTokenSource _cts;
        private List<Tab> tabs;
        private Tab currentTab;


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
            for (int i = startIndex; i < currentTab.Iterations.Count; i++)
            {
                
                if (!ct.IsCancellationRequested)
                {
                    this.InvokeEx(f => f.progress_bar.Value = i);

                    foreach (var note in currentTab.Iterations[i].ActiveNotes)
                    {
                        var bt = form.Controls.Find($"note_{note.StringNumber}_{note.Fret}", true).First();
                        this.InvokeEx(f => bt.Visible = true);

                    }
                    this.InvokeEx(f => f.Update());
                    Thread.Sleep(Convert.ToInt32((currentTab.Tempo * currentTab.Iterations[i].WaitTimeScalar)* 5/100 * Convert.ToInt32(tempoSlowK.Value)));



                    foreach (var note in currentTab.Iterations[i].ActiveNotes)
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
            var indx = tabs.FindIndex(x => x == currentTab);
            if(indx+1 == tabs.Count)
            {
                currentTab = tabs.First();
            }
            else
            {
                currentTab = tabs[indx+1];
            }
            NameLabel.Text = currentTab.Name;
            progress_bar.Maximum = currentTab.Iterations.Count - 1;
            progress_bar.Value = 0;
            _indexOfLastIteration = progress_bar.Value;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
            start_button.Enabled = true;
            var indx = tabs.FindIndex(x => x == currentTab);
            if (indx - 1 < 0)
            {
                currentTab = tabs.Last();
            }
            else
            {
                currentTab = tabs[indx];
            }
            NameLabel.Text = currentTab.Name;
            progress_bar.Maximum = currentTab.Iterations.Count - 1;
            progress_bar.Value = 0;
            _indexOfLastIteration = progress_bar.Value;
        }
    }

}
