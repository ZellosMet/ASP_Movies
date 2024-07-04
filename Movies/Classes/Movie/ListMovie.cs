namespace Movies.Classes.Movie
{
    interface IGetterList
    {
        void PrintListMovies();
    }
    internal class ListMovie : IGetterList
    {
        List<Movie> l_movies = new List<Movie>();
        public ListMovie() { }
        public void Add(Movie movie)
        {
            l_movies.Add(movie);
        }
        public void Remove(Movie movie)
        {
            l_movies.Remove(movie);
        }
        public void Clesr(Movie movie)
        {
            l_movies.Clear();
        }
        public void PrintListMovies()
        {
            foreach (Movie movie in l_movies)
            {
                Console.WriteLine(movie.Name);
            }
        }
    }
}
