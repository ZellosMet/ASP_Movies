namespace Movies.Classes.Movie
{
    public class GetListMovies
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
