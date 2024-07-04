namespace Movies.Classes.Movie
{
    //Класс проигрывателя фильмов
    public class MediaPlayer
    {
        public Movie Movie { get; }
        public int Volume { get; set; }
        public MediaPlayer(Movie movie)
        {
            Movie = movie;
            Volume = 50;
        }
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void ChengingVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine("Current volume: " + Volume);
        }
    }
}
