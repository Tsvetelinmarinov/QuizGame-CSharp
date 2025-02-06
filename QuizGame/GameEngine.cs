/**
 * Game logic
 */



namespace QuizGame
{


    class GameEngine
    {

        //Инициализиране на фунцкионален клас
        Functions appFunctions = new Functions();


        //Съдържа всички въпроси
        string[] questions =
        {
            "Who is Andre Moroa?",
            "Who is Stendhal?",
            "What is the light?",
            "What is the sound?",
            "Wich is the rigth formula of the water?",
            "Wich is the rigth formula of the ammonia?",
            "What is the Otogenesis?",
            "What is the final solusion from the termodinamic?",
            "What is the black color?",
            "What is the ligth color?",
            "Who is George Gordon Biron?"
        };



        //Съдържа всияки отговори
        string[,] answers = 
        {
            { "A. French writer", "B. Italian compisitor" },
            { "A. Russian poet", "B. French writer" }, 
            { "A. Wave", "B. Act both like wave and piece" }, 
            { "A. Piece", "B. Wave" }, 
            { "A. OH3", "B. H2O" }, 
            { "A. CH12", "B. NH3" },
            { "A. Dead", "B. Repeating of the Fillogenesis" },
            { "A. The Universe is going to chaos", "B. The Universe is going cold" },
            { "A. Unvisible color", "B. No color" },
            { "A. Transparency", "B. All the colors in one" }
        };



        //Съдържа всички верни отговора
        string[] Keys = { "A", "B", "B", "B", "B", "B", "B", "B", "B", "B" };




        //Зареди начален екран
        public void LoadMainScreen()
        {
            int inputStream;

            Console.WriteLine("                Daily quiz                \n\n");
            Console.WriteLine("   Choose option\n\n");
            Console.Write("  1. Start quiz\n  2. Quit\n\n   > ");

            inputStream = int.Parse(Console.ReadLine());

            if (inputStream != 1 && inputStream != 2)
            {
                Console.WriteLine("\n\n Invalid input!\n\n");
            }


            switch (inputStream)
            {
                case 1:
                    appFunctions.LoadQuestionsAndAnswers(questions, answers, Keys);
                    break;
                case 2:
                    appFunctions.QuitProgram();
                    break;
                default: Console.WriteLine("\n Invalid input!\n");
                break;
            }


            SwitchUserChoise();

        }


        
        public void SwitchUserChoise()
        {
            Console.Write("\n Do you want to play again?\n Type 'yes' or 'no'\n    > ");
            string userChoose = Console.ReadLine();
            Console.WriteLine("\n\n");

            switch (userChoose)
            {
                case "yes":
                    LoadMainScreen();
                    break;
                case "no":
                    appFunctions.QuitProgram();
                    break;
                default:
                    Console.WriteLine("\n Invalid input!\n");
                    SwitchUserChoise();
                break;
            }
        }

    }


}
