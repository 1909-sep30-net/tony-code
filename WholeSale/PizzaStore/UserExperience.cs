﻿using System;
using  Logic;
 


namespace UserInterface
{
    class UserExperience
    {

        int result;

        static void Main(string[] args)
        {

             while(true)
             {
                DefaultMessage();


                Console.WriteLine("Welcome to YourMarketPlace");

            }





        }

        public void DefaultMessage()
        {
            Start:
            Console.WriteLine("Welcome to YourMarketPlace");
            Console.WriteLine("Press button 1 to register your account.");
            Console.WriteLine("Press button 2 to find your closest store near you.");
            Console.WriteLine("Press button 3 to list all the item for sales.");
            Console.WriteLine("Press button 4 to look for secret sales.");


            var input = Console.ReadLine();
            if( int.TryParse(input, out result))
            {
                if( result == 1)
                {
                    Console.WriteLine("Please enter your First name:");
                    var FName = Console.ReadLine();
                    Console.WriteLine("Please enter your Last name:");
                    var LName  = Console.ReadLine();
                    ZipRestart:
                    Console.WriteLine("What is your 5 digit zip code");
                    var zip = Console.ReadLine();
                    if (zip.Length() != 4)
                    {
                        goto ZipRestart;
                    }

                    int result;
                    if (int.TryParse(zip, out result))
                    {
                        int ZipCode = result;
                    }
                    else
                    {
                        goto ZipRestart;
                    }
                    Customer cust = new Customer(FName, LName, ZipCode);
                }
            }
            else
            {
                Console.Clear();
                goto Start;
            }
           




        }

    }
}
