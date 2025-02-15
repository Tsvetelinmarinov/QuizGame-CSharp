/*
 *  Functions
 */




namespace QuizGame
{


    internal class Functions
    {

        //Точките събрани по време на игра с начална стойнос 0
        private static int _scores;

        //Крайната оценка
        private static int _finalAssessment;


        //Зареди въпросите и отговорите
        public static void LoadQuestionsAndAnswers(string[] questionsArray, string[,] answersArray, string[] keys)
        {
            Console.WriteLine("----------------------------\n\n");

            for (var i = 0; i < questionsArray.Length - 1; i++)
            {
                Console.WriteLine($"\n *Question {i + 1} :\n\n  {questionsArray[i]}\n");

                for (var j = 0; j < answersArray.GetLength(1); j++)
                {
                    Console.WriteLine($"{answersArray[i, j]}");
                }

                Console.Write("\n  Type the answer > ");

                var inputStream = Console.ReadLine()?.ToUpper();

                if (inputStream != null && inputStream.Equals(keys[i]))
                {
                    Console.WriteLine("\n Correct answer!\n");
                    _scores++;
                }
                else
                {
                    Console.WriteLine($"\n Wrong answer!\n Correct answer {keys[i]}\n");
                }

                Console.WriteLine("----------------------------\n\n");
            }


            Console.WriteLine($"\n Assessment : {GetAssessment(_scores)}\n");
            Console.WriteLine($" Scores : {_scores}\n");
            Console.WriteLine($" {GetUserMessage(GetAssessment(_scores))}\n");
            Console.WriteLine("----------------------------\n\n");
        }



        //Генериране на крайна оценка
        private static int GetAssessment(int collectedScores)
        {
            _finalAssessment = collectedScores switch
            {
                0 or 2 => 2,
                3 or 4 => 3,
                5 or 6 => 4,
                7 or 8 => 5,
                9 or 10 => 6,
                _ => 2
            };

            return _finalAssessment;
        }



        //Генериране на съобщение за потребителя
        private static string GetUserMessage(int assessment1)
        {
            var message = assessment1 switch
            {
                2 => "Very bad, like i expect from you!",
                3 => "You hit the middle, but you know that the luck brings you here!",
                4 => "Good, but not so much!",
                5 => "Very good, but not excellent, thing about that!",
                6 => "Excellent! I know you know!",
                _ => "Something went wrong!"
            };

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
