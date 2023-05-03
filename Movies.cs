using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Movies : IGenre
    {
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public Movies(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;

        }

        public void PlayMovies()
        {
            Console.WriteLine($"{Title} is starting, please be quite!");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }
        


    }
