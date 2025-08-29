/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program 
    {
        static void Main(string[] args)
        {*//*
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
            Console.WriteLine("The value of pi is: " + pi);*//*


//Type Casing

//User Input
*//*
            Console.WriteLine("What's youe name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

            Console.ReadKey();*//*


//Arrithmatic Operations
//int friends = 5;
//friends = friends + 1;
//friends += 1; // Incrementing friends by 1
//friends++; // Incrementing friends by 1

*//*   friends = friends * 2;
   friends *= 2; // Multiplying friends by 2*//*

// friends = friends / 2;
//friends /= 2; // Dividing friends by 2S
*//*
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
            Console.WriteLine(lastName);*//*


//If 
*//*Console.WriteLine("Enter your age:");
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

/*
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            if (name == "") //!= null 
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }*//*


//Switch Case
*//*
            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "monday":
                    Console.WriteLine("It's Monday, the start of the week!");
                    break;

                case "Tuesday":
                case "tuesday":
                    Console.WriteLine("It's Tuesday, keep going!");
                    break;

                case "Wednesday":
                case "wednesday":
                    Console.WriteLine("It's Wednesday, we're halfway through!");
                    break;

                case "Thursday":
                case "thursday":
                    Console.WriteLine("It's Thursday, almost the weekend!");
                    break;

                case "Friday":
                case "friday":
                    Console.WriteLine("It's Friday, the weekend is near!");
                    break;

                case "Saturday":
                case "saturday":
                    Console.WriteLine("It's Saturday, time to relax!");
                    break;

                case "Sunday":
                case "sunday":
                    Console.WriteLine("It's Sunday, enjoy your day!");
                    break;

                default:
                    Console.WriteLine("That's not a valid day of the week.");
                    break;
            }*//*

//Logical
*//*
            Console.WriteLine("What's the temparature today?");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <=25)
            {
                Console.WriteLine("It's warm outgside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Do not go outside!4");

            }

 *//*




//WhileLoop
*//*
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            while (name == "")
            {
                Console.Write("Enter Your Name: ");
                name = Console.ReadLine();  
            }
            Console.WriteLine("Hello " + name);
            Console.ReadKey();*/
/*
            Console.WriteLine("Tell me the ...");
            string tell = Console.ReadLine();

            while (tell == "")
            {
                Console.Write("Tell me first: ");
                tell = Console.ReadLine();
            }
            Console.WriteLine("Ok " + tell);
            Console.ReadKey();*/

/*
            while (1 == 1) //
            {
                Console.WriteLine("Stuck in an infinite loop! Press Ctrl+C to exit.");
            }*//*






//For Loops

*//*for (int i = 0; i <= 100; i++)
{
    Console.WriteLine("hi " + i);
}
*/


/*for (int i = 10; i > 0; i--)
{
    Console.WriteLine("hi " + i);
}

*/

/*
            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the character to fill the grid: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(); // Move to the next line after each row
            }*/

/*int rows = 5; // Number of rows

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}*/


/*for (int i = 1; i <=5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
*/
/*
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();*/



/*for (int i = 0; i <= 4; i++)
{ 
  for (int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

for (int i = 4; i >= 0; i--)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}*/







/*



            //Nubmer Guessing Game
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
*/






/*
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();*/

/*
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("........................");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("........................");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero!");
                        }
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }

                Console.Write("Would you like to continue? (Y = yes, N = No): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye");
            Console.ReadKey();*//*







//Arrays

*//*
           String[] cars = { "BMW", "Audi", "Tesla", "Toyota", "Tata", };
            cars[0] = "Mercedes";

           Console.WriteLine(cars[0]);
           Console.WriteLine(cars[1]);
           Console.WriteLine(cars[2]);
           Console.WriteLine(cars[3]);
           Console.WriteLine(cars[4]);
           Console.WriteLine("Total Cars: " + cars.Length);


            Console.ReadKey()


*/
/*

            String[] cars = { "BMW", "Audi", "Tesla", "Toyota", "Tata", };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadLine();*//*


//ForEash Loop

*//*String[] cars = { "BMW", "Audi", "Tesla", "Toyota", "Tata", };

foreach (string car in cars)
{
    Console.WriteLine(car);
}
Console.ReadKey();
*/
/*


            ///Methods

            // method  = performs a section of code, whenever it's called "invoked".
            //           benefit = Let's us reuse code w/o writing it multiple times
            //           Good practice is to capitalize method names (I forgot in this video)

            String name = "Bro";
            int age = 21;

            SingHappyBirthday(name, age);

            Console.ReadKey();
        }
        static void SingHappyBirthday(String birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayBoy);
            Console.WriteLine("You are " + yearsOld + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();*//*
// return  = returns data back to the place where a method is invoked


*//*
            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

            Console.ReadKey();

            static double Multiply(double x, double y)
            {
                return x * y;
            }*//*








        }
    }
}
*/








/*




using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overloading  = methods share same name, but different parameters
            //                       name + parameters = signature
            //                       methods must have a unique signature

            double total;

            total = Multiply(2, 3, 5);

            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}*/












/*


using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

    }
}*/







/*


using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception = errors that occur during execution

            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not

            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.ReadKey();
        }
    }
}*/






/*
using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}*/


/*

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,-10} old.");

            Console.ReadKey();
        }
    }*/

/*


using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                                   { "Corvette", "Camaro", "Silverado" },
                                                   { "Corolla", "Camry", "Rav4" }
                                                 };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";
            *//*
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            *//*
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}*/







/*
//Multi-Dimensional Arrays: 


using System;

namespace MyFirstPrograme
{
    class Programe
    {
        static void Main(string[] args)
        {
            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "Corvette", "Camaro", "Silverado" };
            string[] toyota = { "Corolla", "Camry", "Rav4" };

            string[,] parkinglot =
            {
                {"Mustang", "F-150", "Explorer" },
                {"Corvette", "Camaro", "Silverado" },
                {"Corolla", "Camry", "Rav4" }
            };

            parkinglot[0, 2] = "Fusion";
            parkinglot[2, 2] = "Land Cruiser";
            *//*
                        foreach (string car in parkinglot)
                        {
                            Console.WriteLine(car);
                        }*//*

            for (int i = 0; i < parkinglot.GetLength(0); i++)
            {
                for (int j = 0; j < parkinglot.GetLength(1); j++)
                {
                    Console.Write(parkinglot[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}*/




/*
using System;
using System.Runtime.Remoting.Messaging;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            //              Can be used as a blueprint to create objects (OOP)

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }

}*/




/*
//objects/ field and methods

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Ricky";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}

*/











/*
//Constructors

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2025, "red");
            Car car2 = new Car("Chevy", "Corvette", 2025, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}

*/









/*
//Static modifier

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");
            Car car4 = new Car("Tesla");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
*/









using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Console.ReadKey();
        }
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}



