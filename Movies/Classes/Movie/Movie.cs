namespace Movies.Classes.Movie
{
    //Класс фильмов
    public class Movie
    {
        public string Name { get; }
        public int Duration { get; }
        public string Genre { get; }
        public StyleMovie StyleMovie { get; }
        public Movie(string name, string genre, string style, int duration)
        {
            Name = name;
            Genre = genre;
            Duration = duration;
            StyleMovie = new StyleMovie(style);
        }
        public void GetStyle() 
        {
            Console.WriteLine(StyleMovie.Style);
        }
    }
}
