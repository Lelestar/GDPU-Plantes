using System;
using Choices;

namespace ClassCartes
{
    class Program
    {
        static void Main(string[] args)
        {

            Choice myChoice = new Choices.DefaultChoice();
            Console.WriteLine("Hello World! " + myChoice._description);
        }
    }
    

    
}



