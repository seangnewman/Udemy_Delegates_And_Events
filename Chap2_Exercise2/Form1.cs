using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap2_Exercise2
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

            DisplayMovie();
        }

        private delegate void MovieHandler(Movies movie);

        private void ListMovie(Movies movie)
        {
            moviesListBox.Items.Add(
                String.Format("Name: {0}\t\tGenre: {1}\tRelease Year {2}\tGross: {3}", movie.Name, movie.Genre, movie.ReleaseYear, movie.Gross.ToString("C") )
                );

        }

        private void processMovies(MovieHandler mhandler)
        {
            foreach(Movies movie in movies)
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
            movies.Add(new Movies() {
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
