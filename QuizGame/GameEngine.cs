/*
 * Game logic
 */



namespace QuizGame
{


    internal class GameEngine
    {

        //Инициализиране на фунцкионален клас
        private readonly Functions _appFunctions = new();


        //Съдържа всички въпроси
        private readonly string[] _questions =
        [
            "Who is Andre Moroa?",
            "Who is Stendhal?",
            "What is the light?",
            "What is the sound?",
            "Which is the right formula of the water?",
            "Which is the right formula of the ammonia?",
            "What is the Oto genesis?",
            "What is the final solution from the thermodynamic?",
            "What is the black color?",
            "What is the white color?",
            "Who is George Gordon Biron?"
        ];



        //Съдържа всички отговори
        private readonly string[,] _answers = 
        {
            { "A. French writer", "B. Italian compositor" },
            { "A. Russian poet", "B. French writer" }, 
            { "A. Wave", "B. Act both like wave and piece" }, 
            { "A. Piece", "B. Wave" }, 
            { "A. OH3", "B. H2O" }, 
            { "A. CH12", "B. NH3" },
            { "A. Dead", "B. Repeating of the Salutogenesis" },
            { "A. The Universe is going to chaos", "B. The Universe is going cold" },
            { "A. Invisible color", "B. No color" },
            { "A. Transparency", "B. All the colors in one" }
        };



        //Съдържа всички верни отговори
        private readonly string[] _keys = ["A", "B", "B", "B", "B", "B", "B", "B", "B", "B"];




        //Зареди начален екран
        public void LoadMainScreen()
        {
            Console.WriteLine("                Daily quiz                \n\n");
            Console.WriteLine("   Choose option\n\n");
            Console.Write("  1. Start quiz\n  2. Quit\n\n   > ");

            var inputStream = int.Parse(Console.ReadLine() ?? string.Empty);

            if (inputStream != 1 && inputStream != 2)
            {
                Console.WriteLine("\n\n Invalid input!\n\n");
            }



            switch (inputStream)
            {
                case 1:
                    Functions.LoadQuestionsAndAnswers(_questions, _answers, _keys);
                    break;
                case 2:
                    _appFunctions.QuitProgram();
                    break;
                default:
                    Console.WriteLine("\n\n Invalid input!\n\n");
                break;
            }

            SwitchUserChoose();

        }


        private void SwitchUserChoose()
        {
            while (true)
            {
                Console.Write("\n Do you want to play again?\n Type 'yes' or 'no'\n    > ");
                var userChoose = Console.ReadLine();
                Console.WriteLine("\n\n");

                switch (userChoose)
                {
                    case "yes":
                        LoadMainScreen();
                        break;
                    case "no":
                        _appFunctions.QuitProgram();
                        break;
                    default:
                        Console.WriteLine("\n Invalid input!\n");
                    continue;
                }

                break;
            }
        }
    }


}
