/*
 * Game control panel
 */


namespace QuizGame
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var engine = new GameEngine();
            engine.LoadMainScreen();
        }


    }


}