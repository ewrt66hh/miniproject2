using System;

namespace rrtttefghj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = GetStudentName();
            string studentID = GetStudentID();
            int selection = GetMathOperation();

            int score = AskMathQuestions(selection);
            ShowResult(studentName, studentID, score, 10);
        }

        static string GetStudentName()
        {
            Console.Write("Fadlan geli magacaaga: ");
            return Console.ReadLine();
        }

        static string GetStudentID()
        {
            Console.Write("Fadlan geli ID-gaaga: ");
            return Console.ReadLine();
        }

        static int GetMathOperation()
        {
            Console.WriteLine("\n== Xulo nooca xisaabta ==\n1. Kudar\n2. Kajar\n3. Kudhufo\n4. Qaybi");
            Console.Write("Xulashadaada (1-4): ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int AskMathQuestions(int selection)
        {
            int trueAnswers = 0;
            int totalQuestions = 10;
            Random generator = new Random();

            for (int num = 1; num <= totalQuestions; num++)
            {
                int x = generator.Next(1, 20);
                int y = generator.Next(1, 20);
                int correctAnswer = 0;

                switch (selection)
                {
                    case 1:
                        Console.Write($"Q{num}: {x} + {y} = ");
                        correctAnswer = x + y;
                        break;
                    case 2:
                        Console.Write($"Q{num}: {x} - {y} = ");
                        correctAnswer = x - y;
                        break;
                    case 3:
                        Console.Write($"Q{num}: {x} * {y} = ");
                        correctAnswer = x * y;
                        break;
                    case 4:
                        x = x * y;
                        Console.Write($"Q{num}: {x} / {y} = ");
                        correctAnswer = x / y;
                        break;
                    default:
                        Console.WriteLine("Xulashada khaldan!");
                        return 0;
                }

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("👏 Waa sax!\n");
                    trueAnswers++;
                }
                else
                {
                    Console.WriteLine($"❌ Waa khalad! Jawaabta saxda ahayd waa: {correctAnswer}\n");
                }
            }

            return trueAnswers;
        }

        static void ShowResult(string name, string id, int correct, int total)
        {
            int incorrect = total - correct;
            int percentage = (correct * 100) / total;

            Console.WriteLine("\n--- Natiijadaada ---");
            Console.WriteLine($"Magaca: {name}");
            Console.WriteLine($"ID-ga: {id}");
            Console.WriteLine($"Sax: {correct} | Khalad: {incorrect}");
            Console.WriteLine($"Guud ahaan: {percentage}%");
        }
    }
}


