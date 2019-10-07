using System;
using ShapesApp.Library;

namespace ShapesApp.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Length ");
            string input;
            double length;
            do {
                Console.WriteLine("Enter a Length: ");
                input = Console.ReadLine();
            }while(!double.TryParse(input, out length ));

             Rectangle a = new Rectangle();

            //c# has something called out paramenters 


        }
    }
}
