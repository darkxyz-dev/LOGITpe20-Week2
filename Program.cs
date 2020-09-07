using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Create an app
             * 1. App asks the user´s name and greets the users by it´s name;
             * 2. App asks the user´s age and calculates
             * what year the user was born;
             * 3. App displays the result to the user
             * */
            Console.WriteLine("What is your name?");
            String Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);
            Console.WriteLine("How old are you?");
            String UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("Your year of birth is" + Age);










        }
    }
}
