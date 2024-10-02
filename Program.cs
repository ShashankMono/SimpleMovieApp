using MovieAppWithSeriallizer.Models;

namespace MovieAppWithSeriallizer
{
    internal class Program
    {
        public static List<Movie> movies = DataSerializer.Deserialize();
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        public static void DisplayMenu() {
            while (true) {
                Console.WriteLine($"\nWelcome! to Movies App\n" +
                    $"Choose option\n" +
                    $"1.Display Movies\n" +
                    $"2.Add Movie\n" +
                    $"3.Clear All\n" +
                    $"4.Exit\n");
                int choice = int.Parse( Console.ReadLine() );
                RunCasesOfMovieApp( choice );
            }
        }

        public static void RunCasesOfMovieApp(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine(Movie.DisplayMovies(movies));
                    break;

                case 2:
                    AddMovie();
                    break;

                case 3:
                    Console.WriteLine(Movie.ClearAllMovies(movies));
                    break;

                case 4:
                    DataSerializer.Serializer(movies);
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("please choose correct option\n");
                    break;

            }
        }

        public static void AddMovie()
        {
            Console.WriteLine("Enter movie Id:\n");
            int id = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter movie name:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Enter genre of movie:\n");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter release year of movie:\n");
            int year = int.Parse( Console.ReadLine() );

            Movie movie = new Movie(id,name,genre,year);
            movies.Add(movie);
            Console.WriteLine("Movie Added sucessfully!");
        }
    }
}
