/**
 *  Functions
 */




namespace QuizGame
{


    class Functions
    {

        //Точките събрани по време на игра с начална стойнос 0
        int scores;

        //Крайната оценка
        int finalAssessment;


        //Зареди въпросите и отговорите
        public void LoadQuestionsAndAnswers(string[] questionsArray, string[,] answersArray, string[] keys)
        {
            Console.WriteLine("----------------------------\n\n");

            for (int i = 0; i < questionsArray.Length - 1; i++)
            {
                Console.WriteLine($"\n Question {i + 1} :\n  {questionsArray[i]}\n");

                for (int j = 0; j < answersArray.GetLength(1); j++)
                {
                    Console.WriteLine($"{answersArray[i, j]}\n");
                }

                Console.Write("\n   Type the answer > ");

                string inputStream = Console.ReadLine().ToUpper();

                if (inputStream.Equals(keys[i]))
                {
                    Console.WriteLine("\n Correct answer!\n");
                    scores ++;
                }
                else
                {
                    Console.WriteLine($"\n Wrong answer!\n Correct answer {keys[i]}\n");
                }

                Console.WriteLine("----------------------------\n\n");
            }


            Console.WriteLine($"\n Assessment : {GetAssessment(scores)}\n");
            Console.WriteLine($" Scores : {scores}\n");
            Console.WriteLine($" {GetUserMessage(GetAssessment(scores))}\n");
            Console.WriteLine("----------------------------\n\n");
        }



        //Генериране на крайна оценка
        public int GetAssessment(int collectedScores)
        {
            switch (collectedScores)
            {
                case 0:
                case 2:
                    finalAssessment = 2;
                    break;
                case 3:
                case 4:
                    finalAssessment = 3;
                    break;
                case 5:
                case 6:
                    finalAssessment = 4;
                    break;
                case 7:
                case 8:
                    finalAssessment = 5;
                    break;
                case 9:
                case 10:
                    finalAssessment = 6;
                    break;
                default:
                    finalAssessment = 2;
                break;
            }

            return finalAssessment;
        }



        //Генериране на съобщение за потребителя
        public string GetUserMessage(int assessment1)
        {
            string message;

            switch (assessment1)
            {
                case 2:
                    message = "Very bad, like i expect from you!";
                    break;
                case 3:
                    message = "You hit the middle, but you know that the luck brings you here!";
                    break;
                case 4:
                    message = "Good, but not so much!";
                    break;
                case 5:
                    message = "Very good, but not excellent, thing about that!";
                    break;
                case 6:
                    message = "Excellent! I know you know!";
                    break;
                default:
                    message = "Something went wrong!";
                break;
            }

            return message;
        }



        //Изход от играта
        public void QuitProgram()
        {
            Console.WriteLine("\n\n  Goodbye!\n\n");
            Environment.Exit(0);
        }


    }


}
