using System;

namespace Interface
{
    class Program
{
    static void Main(string[] args)
    {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movies myMovies = new Movies("R", "Action/Comedy", "Team America: World Police");
            Console.WriteLine(myMovies.Describe());
            myMovies.PlayMovies();
        }
}
}
