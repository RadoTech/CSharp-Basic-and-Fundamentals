using System;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            int moviesCount = int.Parse(Console.ReadLine());

            //Logic:

            double movieLowestRating = double.MaxValue;
            double movieHighestRating = double.MinValue;
            double movieAverageRating = 0;

            string movieLowestRatingName = String.Empty;
            string movieHighestRatingName = String.Empty;

            

            for (int currentMovie = 1; currentMovie <= moviesCount; currentMovie++)
            {
                string currentMovieName = Console.ReadLine();
                double currentMovieRating = double.Parse(Console.ReadLine());

                if (currentMovieRating > movieHighestRating)
                {
                    movieHighestRating = currentMovieRating;
                    movieHighestRatingName = currentMovieName;

                }
                if (currentMovieRating < movieLowestRating)
                {
                    movieLowestRating = currentMovieRating;
                    movieLowestRatingName = currentMovieName;
                }
                movieAverageRating += currentMovieRating;
                             
            }
            Console.WriteLine($"{movieHighestRatingName} is with highest rating: {movieHighestRating:f1}");
            Console.WriteLine($"{movieLowestRatingName} is with lowest rating: {movieLowestRating:f1}");
            Console.WriteLine($"Average rating: {(movieAverageRating / moviesCount):f1}");
        }
    }
}
