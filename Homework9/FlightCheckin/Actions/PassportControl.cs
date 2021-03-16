using System;
using System.Collections.Generic;
using FlightCheckin.Utilities;

namespace FlightCheckin.Actions
{
    class PassportControl
    {
        internal static void Commence(Passenger passenger)
        {
            Console.WriteLine("You proceed to Passport Control, stand in the line and take a look at your passport");
            passenger.passport.InitializePassportInfo();
            passenger.passport.ShowPassport();
            Effect.ImitateLoading(8);
            InspectPassport(passenger);
            AskRandomQuestion(passenger);

            Console.WriteLine("Everything is in order. You may proceed to Security Check.");
            Effect.ImitateLoading(5);
        }

        internal static void InspectPassport(Passenger passenger)
        {
            Console.WriteLine("You reach the end of the line and hand your passport to the inspector.");
            Effect.ImitateLoading(5);
            AirportService.CheckForCriticalCondition(passenger.passport.IsValid, CriticalConditions.invalidPassport);
            AirportService.CheckForCriticalCondition(passenger.passport.HasValidVisa, CriticalConditions.noValidVisa);
        }

        internal static void AskRandomQuestion(Passenger passenger)
        {
            string randomQuestion = RandomQuestion();
            string correctAnswer = CorrectAnswer(passenger, randomQuestion);

            Console.WriteLine("(the inspector looks at you and suddenly asks you a question");
            
            Console.WriteLine(randomQuestion);
            string answer = Console.ReadLine();

            while(answer != correctAnswer)
            {
                passenger.SuspiciousBehaviour++;
                if (passenger.SuspiciousBehaviour >= 3)
                    AirportService.CheckForCriticalCondition(passenger.SuspiciousBehaviour < 3, CriticalConditions.tooSuspicious);

                Console.WriteLine("Try again, it's not correct.");
                Console.WriteLine(randomQuestion);
                answer = Console.ReadLine();
            }
        }

        static string RandomQuestion()
        {
            Random rand = new Random();
            string[] questions = new string[]
            {
                "What is your name?",
                "What is your last name?",
                "What is your passport number?"
            };

            string randomQuestion = questions[rand.Next(0, questions.Length)];
            return randomQuestion;
        }

        static string CorrectAnswer(Passenger passenger, string question)
        {
            string correctAnswer = string.Empty;
            switch (question)
            {
                case "What is your name?":
                    correctAnswer = passenger.Name;
                    break;
                case "What is your last name?":
                    correctAnswer = passenger.Lastname;
                    break;
                case "What is your passport number?":
                    correctAnswer = passenger.passport.Number;
                    break;
                default:
                    break;
            }

            return correctAnswer;
        }
    }
}
