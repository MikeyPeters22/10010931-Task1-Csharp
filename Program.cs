using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("================================================================");
            Console.WriteLine("This Program will check two numbers and see which one is greater");
            Console.WriteLine("================================================================");
            

            Console.WriteLine("Please give me one number");
            int userInput1 = (Console.Readline());
            Console.WriteLine(userInput1);

            Console.WriteLine("Please give me another number");
            int userInput2 = (Console.Readline());

            Console.WriteLine(userInput2);

            if (userInput1 > userInput2)
            {
                Console.WriteLine($"{userInput1} is greater than {userInput2}");
                
            }
            else {
                Console.WriteLine($"{userInput2} is greater than {userInput1}");
            
            }
            Console.Readline();
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to  quit program");
            console.Readkey();

        }
    }
}
