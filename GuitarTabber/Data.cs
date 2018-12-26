using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarTabber
{
    class Data
    {
        public List<Tab> GetAllTabs()
        {
            var list = new List<Tab>()
            {
            new Tab()
            {
                Creator = "Asd",
                Name = "Legato exercise",
                Tempo = 60,
                Iterations = new List<TabIteration>()
                {
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=1},
                            new Note() {StringNumber=5, Fret=1},
                            new Note() {StringNumber=3, Fret=3}
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=3, Fret=2},
                            new Note() {StringNumber=6, Fret=3},
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
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
                            new Note() {StringNumber=1, Fret=2},
                            new Note() {StringNumber=2, Fret=1},
                            new Note() {StringNumber=4, Fret=0}
                        }
                    },
                     new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=0},
                            new Note() {StringNumber=4, Fret=0}
                        }
                    },
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=1, Fret=1},
                             new Note() {StringNumber=2, Fret=1},
                             new Note() {StringNumber=3, Fret=1},
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
              },
             new Tab()
            {
                Creator = "Asd",
                Name = "Chord exercise",
                Tempo = 60,
                Iterations = new List<TabIteration>()
                {
                    new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=1},
                            new Note() {StringNumber=5, Fret=1},
                            new Note() {StringNumber=3, Fret=3}
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
                            new Note() {StringNumber=4, Fret=0},
                            new Note() {StringNumber=3, Fret=0},
                            new Note() {StringNumber=5, Fret=0}
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
                            new Note() {StringNumber=4, Fret=0},
                            new Note() {StringNumber=3, Fret=0},
                            new Note() {StringNumber=5, Fret=0}
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
                            new Note() {StringNumber=4, Fret=0},
                            new Note() {StringNumber=3, Fret=0},
                            new Note() {StringNumber=5, Fret=0}
                        }
                    }, new TabIteration()
                    {
                        WaitTimeScalar=2,
                        ActiveNotes = new List<Note>()
                        {
                            new Note() {StringNumber=6, Fret=2},
                            new Note() {StringNumber=5, Fret=2}
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
                            new Note() {StringNumber=1, Fret=3},
                            new Note() {StringNumber=3, Fret=4},
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
              },
             new Tab()
             {
                  Creator = "Asd",
                Name = "Solo exercise",
                Tempo = 60,
                Iterations = new List<TabIteration>()
                {
                    new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=6},
                        }
                    },
                      new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=4},
                        }
                    },
                        new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=2,Fret=6},
                        }
                    },
                          new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=7},
                        }
                    },
                            new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=3,Fret=6},
                        }
                    },
                              new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=3,Fret=5},
                        }
                    },
                                new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=9},
                        }
                    },
                                  new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=12},
                        }
                    },
                                    new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=2,Fret=14},
                        }
                    },
                                      new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=12},
                        }
                    },
                                         new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=4},
                        }
                    },
                        new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=2,Fret=6},
                        }
                    },
                          new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=7},
                        }
                    },
                            new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=3,Fret=6},
                        }
                    },
                              new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=3,Fret=5},
                        }
                    },
                                new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=9},
                        }
                    },
                                  new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=12},
                        }
                    },
                                    new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=2,Fret=14},
                        }
                    },
                                      new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=12},
                        }
                    },
                                         new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=4},
                        }
                    },
                        new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=2,Fret=6},
                        }
                    },
                          new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=7},
                        }
                    },
                            new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=3,Fret=6},
                        }
                    },
                              new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=3,Fret=5},
                        }
                    },
                                new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=9},
                        }
                    },
                                  new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=12},
                        }
                    },
                                    new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=2,Fret=14},
                        }
                    },
                                      new TabIteration()
                    {
                        WaitTimeScalar = 1,
                        ActiveNotes = new List<Note>()
                        {
                            new Note(){StringNumber=1,Fret=12},
                        }
                    },

                }
             }
            };
            return list;

        }
    }
}
