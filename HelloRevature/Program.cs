using System;

namespace Hellorevature
{
    class Program
    {
        static void Main(string[] args)
        {
      

        int i = 0;
        goto check;
        loop:
        Console.WriteLine("hello world");
        check:
        if (i < 2){ 
                        i++;

        goto loop;
        }
        }
    }
}
