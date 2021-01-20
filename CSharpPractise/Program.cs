using System;

namespace CSharpPractise
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a variable (container) to contain data - name and age will change
            string characterName = "Holly";
            int characterAge = 10;

            Console.WriteLine("There is a girl called " + characterName);
            Console.WriteLine("She is " + characterAge + " years old");
            Console.WriteLine("Her bestfriend is also called Holly");
            Console.WriteLine("They are both 10 years old");

            Console.ReadLine();
        }
    }
}
