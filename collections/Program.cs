using System;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Arrays();

        }
        static void Arrays()
        {
            // arrays are the most basic ways to group the same type of data 
            int[] a= new int[4];
            a[0]=1;
            a[1]=3;
            a[3]=5;
            Console.WriteLine("a0"+ a[0]);
        }
    }
}
