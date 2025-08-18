using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program 
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Hello, World!");
            Console.Write("asap");
            Console.WriteLine("Press any key to exit...");
            Console.Beep();
            //Console.ReadLine();*/

            /*int x;
            x = 123;
            int y = 456;
            int z = x + y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/
            /*
                        //Variables
                        int age = 28;
                        Double height = 180.50;
                        bool alive = true;
                        Char simble = '@';
                        string name = "John Doe";
                        string username = simble + name;

                        Console.WriteLine("Your age is: " + age);
                        Console.WriteLine("Your height is: " + height + "cm");
                        Console.WriteLine("Are you alive? " + alive);
                        Console.WriteLine("Your symbol is: " + simble);
                        Console.WriteLine("Your name is: " + name);
                        Console.WriteLine("Your username is: " + username);*/
            /*
                        // Constants
                        const double pi = 3.1416;
                        Console.WriteLine("The value of pi is: " + pi);*/


            //Type Casing

            //User Input
            /*
                        Console.WriteLine("What's youe name?");
                        string name = Console.ReadLine();

                        Console.WriteLine("What's your age?");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

                        Console.ReadKey();*/


            //Arrithmatic Operations
            //int friends = 5;
            //friends = friends + 1;
            //friends += 1; // Incrementing friends by 1
            //friends++; // Incrementing friends by 1

            /*   friends = friends * 2;
               friends *= 2; // Multiplying friends by 2*/

            // friends = friends / 2;
            //friends /= 2; // Dividing friends by 2S
            /*
                        int remainder = friends % 2;
                        Console.WriteLine(remainder);*/



            /*
                        //Console.WriteLine(friends);

                        String fullName = "Bro Code";
                        String phoneNumber = "123-456-7890";

                        //fullName = fullName.ToUpper();
                        //fullName = fullName.ToLower();
                        //Console.WriteLine(fullName);

                        //phoneNumber = phoneNumber.Replace("-","");
                        //Console.WriteLine(phoneNumber);

                        //String userName = fullName.Insert(0,"Mr.");
                        //Console.WriteLine(userName);

                        //Console.WriteLine(fullName.Length);

                        String firstName = fullName.Substring(0, 3);
                        String lastName = fullName.Substring(4, 4);

                        Console.WriteLine(firstName);
                        Console.WriteLine(lastName);*/


            //If 
            /*Console.WriteLine("Enter your age:");
            int age = Convert .ToInt32(Console.ReadLine());

            if (age <= 0)
            {
                Console.WriteLine("You haven't been born yet.");
            }
            else if (age >= 100)
            {
                Console.WriteLine("Your are an Oldman");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age >= 13)
            {
                Console.WriteLine("You are a teenager.");
            }
            
            else
            {
                Console.WriteLine("You are a child.");
            }

            Console.ReadKey();*/


            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            if (name == "") //!= null 
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }


        }
    }
}
