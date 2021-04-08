using System;

namespace helloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            string name = "Mieszko";
            float age = 1.5f;

            int num1 = 20;
            int num2 = 5;

            int sum = num1 + num2;

            Console.WriteLine("Hello " + name + ", masz " + age);

            Console.WriteLine(name);

            Console.WriteLine(age);

            Console.WriteLine(sum);

            Console.Write("Wprowadz text:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Twoja wiadomość to: {0}", userInput);

            Console.Read();
            */

            //this will work. can assing smal values to biger vaules
            int someNum = 459412;
            long myLongNum = someNum;

            float myFloat = 13.73F;
            double myNewDouble = myFloat;


            //not working shows only 13
            double myDouble = 13.73;
            int myInt;

            //cast double to int - change init to mydouble only shows 13
            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.Read();


            //convert type from num to string
            string myString = myDouble.ToString();
        }
    }
}
