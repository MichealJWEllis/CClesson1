using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Console.WriteLine("Please enter a name: (leave empty to exit): ");
            while (true)
            {

                string firstName = Console.ReadLine();

                if (firstName == "")
                {
                    break;
                }
                // 
                Console.WriteLine("Enter last name: ");
                string lastName = Console.ReadLine();
                if (lastName == "")
                {
                    break;
                }
                Console.WriteLine("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();
                Console.WriteLine("Add another employee?");
                // Create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                // Add currentEmployee, not a string

                employees.Add(currentEmployee);
            }
            // Update the method return type

            return employees;
        }
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            // string greeting = "hello";
            // greeting = greeting + "world";
            // Console.WriteLine("greeting" + greeting);
            // Console.WriteLine($"greeting {greeting}");
            // Console.WriteLine("greeting: {0}", greeting);
            //Console.WriteLine("Hello World!");
            //double side = 3.14;
            //double Area = side * side;

            //Console.WriteLine("Area is a {0}", Area.GetType());

            // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
            // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
            // Console.WriteLine(1 + 2 * 3);     // order of operations
            // Console.WriteLine(10 / 3.0);      // int's and doubles
            // Console.WriteLine(10 / 3);        // int's 
            // Console.WriteLine("12" + "3");    // What happens here?

            // int num = 10;
            // num += 100;
            // Console.WriteLine(num);
            // num++;
            // Console.WriteLine(num);

            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice");
            // Console.WriteLine(!isCold ? "drink" : "add ice");

            // string stringNum = "2";
            // int intNum = Convert.ToInt16(stringNum);
            // Console.WriteLine(intNum);
            // Console.WriteLine(intNum.GetType());

            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>() {
            //     {"firstInning", 10},
            //     {"secondInning",20},
            //     {"thirdInning",30},
            //     {"fourthInning",40},
            //     {"fifthInning",50}
            // };
            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

            // myScoreBoard.Add("firstInning", 10);
            // myScoreBoard.Add("secondInning", 20);
            // myScoreBoard.Add("thirdInning", 30);
            // myScoreBoard.Add("fourthInning", 40);
            // myScoreBoard.Add("fifthInning", 50);


            // Console.WriteLine("----------------");
            // Console.WriteLine("  Scoreboard");
            // Console.WriteLine("----------------");
            // Console.WriteLine("Inning |  Score");
            // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

            // string[] favFoods = new string[3] { "pizza", "doughnuts", "icecream" };
            // string firstFood = favFoods[0];
            // string secondFood = favFoods[1];
            // string thirdFood = favFoods[2];
            // Console.WriteLine("I like {0}, {1},and {2}", firstFood, secondFood, thirdFood);
            // Changes made for git test
            // List<string> employees = new List<string>();
            // // { "adam", "amy" };
            // // Collect user values until the value is an empty string
            // while (true)
            // {
            //     Console.WriteLine("Please enter a name: ");
            //     string input = Console.ReadLine();
            //     employees.Add(input);
            // }
            // for (int i = 0; i < employees.Count; i++)
            // {
            //     Console.WriteLine(employees[i]);
            // }

            // employees.Add("barbara");
            // employees.Add("billy");

            // Get a name from the console and assign it to a variable


            // Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
            // for (int i = 0; i < employees.Count; i++)
            // {
            //     Console.WriteLine("My employees include " + employees[i]);
            // }
            //     List<string> employees = new List<string>();

            //     // Collect user values until the value is an empty string

            //     while (true)

            //     {

            //         Console.WriteLine("Please enter a name: (leave empty to exit): ");

            //         string input = Console.ReadLine();

            //         employees.Add(input);

            //     }

            //     for (int i = 0; i < employees.Count; i++)

            //     {

            //         Console.WriteLine(employees[i]);

            //     }
            // }

            // while (true)
            // {
            //     Console.WriteLine("Please enter a name: (leave empty to exit): ");
            //     string input = Console.ReadLine();
            //     // Break if the user hits ENTER without typing a name
            //     if (input == "")
            //     {
            //         break;
            //     }
            //     employees.Add(input);
            // }

            // This is our employee-getting code now

        }

    }
}
