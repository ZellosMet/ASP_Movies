namespace Movies.Classes.Movie
{
    //Класс для получения фильмов из списка 
    internal class GetListMovies
    {
        IGetterList list;
        public GetListMovies(IGetterList list)
        {
            this.list = list;
        }
        void GetList()
        {
            list.PrintListMovies();
        }
    }
}
