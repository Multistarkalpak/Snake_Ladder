// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("==========Welcome To Snake And Ladder Game========");

            Console.WriteLine("Initital Position of both Players is 0");

            final_game snakeAndLadder = new final_game();
            snakeAndLadder.InitGame();


        }
    }
}
