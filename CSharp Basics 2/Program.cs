using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTypes();
        }

        static void MyString()
        {

            // This is a comment
            /// 1
            /// 2
            /// 3
            Console.Write("what year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string myString1 = "This is my first String.";
            string theTruth = "The last thing a ninja would do is admit to being a ninja";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my String. " + myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine("Mr. Sekol is the best ever.");

        }

        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob The Builder";
            bool awesome = true;
            char grade = 'F'; // Chars are single characters.  requires single quote. 'F'
            float altitude = 90.265141f; //float requires 'f' at the end.
            double bankBalance = -40000000000;
            decimal pi = 3.14159265359M; // decimal requires an M at the end.


            /// OutPut
            /// 
            Console.WriteLine($"myAge = {myAge}");
            Console.WriteLine($"string = {name}");
            Console.WriteLine($"bool = {awesome}");
            Console.WriteLine($"char = {grade}");
            Console.WriteLine($"float = {altitude}");
            Console.WriteLine($"double = {bankBalance}");
            Console.WriteLine($"decimal = {pi}");
           

      }
    }
}
