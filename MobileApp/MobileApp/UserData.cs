using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp
{

        class UserData
        {
            public List<User> GetUsers()
            {
                var firstCourses = new List<Course>()
            {
                new Course()
                {
                    Name = "Chords course",
                    Type = InstrumentType.Guitar,
                    Lessons = new List<Model.GuitarTab.Lesson>()
                    {
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 1",
                            Tab = new Tab()
                            {
                                Creator = "Johny",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 1",
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
                                }
                            },

                        },
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 2",
                            Tab = new Tab()
                            {
                                Creator = "Johny",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 2",
                                Tempo = 80,
                                Iterations = new List<TabIteration>()
                                {

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
                                }
                            },
                        },
                         new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 3",
                            Tab = new Tab()
                            {
                                Creator = "Petruci",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 3",
                                Tempo = 120,
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
                                }
                            },

                        }

                    }
                },
                new Course()
                {
                    Name = "Legato course",
                    Type = InstrumentType.Guitar,
                    Lessons = new List<Model.GuitarTab.Lesson>()
                    {
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 1",
                            Tab = new Tab()
                            {
                                Creator = "Gabriell",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 1",
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
                                }
                            },

                        },
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 2",
                            Tab = new Tab()
                            {
                                Creator = "Anthony",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 2",
                                Tempo = 80,
                                Iterations = new List<TabIteration>()
                                {

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
                                }
                            },
                        },
                    }
                }
            };

                var secondCourses = new List<Course>()
            {
                  new Course()
                {
                    Name = "Chords course",
                    Type = InstrumentType.Guitar,
                    Lessons = new List<Model.GuitarTab.Lesson>()
                    {
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 1",
                            Tab = new Tab()
                            {
                                Creator = "Johny",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 1",
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
                                }
                            },

                        },
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 2",
                            Tab = new Tab()
                            {
                                Creator = "Johny",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 2",
                                Tempo = 80,
                                Iterations = new List<TabIteration>()
                                {

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
                                }
                            },
                        },
                         new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 3",
                            Tab = new Tab()
                            {
                                Creator = "Petruci",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 3",
                                Tempo = 120,
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
                                }
                            },

                        }

                    }
                },
                  new Course()
                {
                    Name = "Solo course",
                    Type = InstrumentType.Guitar,
                    Lessons = new List<Model.GuitarTab.Lesson>()
                    {
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 1",
                            Tab = new Tab()
                            {
                                Creator = "Johny",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 1",
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
                                }
                            },

                        },
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 2",
                            Tab = new Tab()
                            {
                                Creator = "Johny",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 2",
                                Tempo = 80,
                                Iterations = new List<TabIteration>()
                                {

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
                                }
                            },
                        },
                         new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 3",
                            Tab = new Tab()
                            {
                                Creator = "Petruci",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 3",
                                Tempo = 120,
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
                                }
                            },

                        },
                          new Model.GuitarTab.Lesson()
                        {
                            Name = "Final exam",
                            Tab = new Tab()
                            {
                                Creator = "Gilbert",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Final exam",
                                Tempo = 180,
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
                                }
                            },

                        },

                    }
                },
                  new Course()
                {
                    Name = "Legato course",
                    Type = InstrumentType.Guitar,
                    Lessons = new List<Model.GuitarTab.Lesson>()
                    {
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 1",
                            Tab = new Tab()
                            {
                                Creator = "Gatrie Govan",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 1",
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
                                }
                            },

                        },
                        new Model.GuitarTab.Lesson()
                        {
                            Name = "Exercice 2",
                            Tab = new Tab()
                            {
                                Creator = "Anthony",
                                GuitarType = InstrumentType.Guitar,
                                Name = "Exercise 2",
                                Tempo = 80,
                                Iterations = new List<TabIteration>()
                                {

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
                                }
                            },
                        },
                    }
                }
            };

            var all = new List<Course>();
            all.AddRange(firstCourses);
            all.AddRange(secondCourses);
            var list = new List<User>()
            {
                new User()
                {
                    Password = "1234",
                    UserName = "Lavsiant",
                    FirstName = "Andrey",
                    LastName = "Konkin",
                    Email = "lavsiant@gmail.com",
                    Courses = firstCourses
                },
                new User()
                {
                     Password = "1234",
                    UserName = "Koss",
                    FirstName = "Kostya",
                    LastName = "Medushev",
                    Email = "kos@gmail.com",
                    Courses = secondCourses
                },
                new User()
                {
                    Password="admin",
                    UserName="admin",
                    FirstName = "Admin",
                    LastName = "Adminovich",
                    Email = "admin@admin.com",
                    Courses = all
                }
            };
                return list;
            }
        }
    }

