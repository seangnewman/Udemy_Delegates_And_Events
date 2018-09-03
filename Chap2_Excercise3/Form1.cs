using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap2_Excercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Movies> movies = new List<Movies>();

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMovies();
            MessageBox.Show(returnDate());
            MessageBox.Show(returnTime());
            DisplayMovie();
        }

        // Using the built-in Action delegate
        //private delegate void MovieHandler(Movies movie);

        private string returnDate()
        {
            Func<DateTime, string> todayGreeting;
            todayGreeting = returnGreeting;
            return todayGreeting(DateTime.Now);
        }

        public string returnTime()
        {
            Func<DateTime, string> todayGreeting;
            todayGreeting = returnTimeGreeting;
            return todayGreeting(DateTime.Now);

        }

        private string returnGreeting(DateTime greetDate)
        {
            return String.Format("Hello!  Today is {0}.", greetDate.ToShortDateString());
        }

        private string returnTimeGreeting(DateTime greetDate)
        {
            return String.Format("Hello!  The time is {0}.", greetDate.ToShortTimeString());
        }

        private void ListMovie(Movies movie)
        {
            moviesListBox.Items.Add(
                String.Format("Name: {0}\t\tGenre: {1}\tRelease Year {2}\tGross: {3}", movie.Name, movie.Genre, movie.ReleaseYear, movie.Gross.ToString("C"))
                );

        }

        //private void processMovies(MovieHandler mhandler)
        private void processMovies(Action<Movies> mhandler)
        {
            foreach (Movies movie in movies)
            {
                mhandler(movie);
            }
        }



        private void DisplayMovie()
        {
            moviesListBox.Items.Clear();
            processMovies(ListMovie);
        }

        private void InitializeMovies()
        {
            movies.Add(new Movies()
            {
                Name = "Blade Runner",
                Genre = "SciFi",
                ReleaseYear = "1982",
                Gross = 11000L
            });
            movies.Add(new Movies()
            {
                Name = "Star Wars",
                Genre = "SciFi",
                ReleaseYear = "1977",
                Gross = 12000L
            });

            movies.Add(new Movies()
            {
                Name = "Avengers",
                Genre = "Superhero",
                ReleaseYear = "2012",
                Gross = 13000L
            });

            movies.Add(new Movies()
            {
                Name = "Batman",
                Genre = "Superhero",
                ReleaseYear = "1966",
                Gross = 14000L
            });

            movies.Add(new Movies()
            {
                Name = "Batman",
                Genre = "Superhero",
                ReleaseYear = "1989",
                Gross = 15000L
            });

        }
        private void adjustGross(Movies movie)
        {
            movie.Gross -= 100L;

        }
        private void adjustGrossButton_Click(object sender, EventArgs e)
        {
            processMovies(adjustGross);
            DisplayMovie();
        }
    }

}
