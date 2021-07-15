using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Accounts;

namespace csharp_edu
{
    class Program
    {
        delegate int Calculate(int one, int two);

        static void Main(string[] args)
        {
            // #region console
            //
            // Console.Write("What is your name? ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hello, " + name);
            //
            // #endregion
            //
            // #region data types
            //
            // bool canVote = true;
            //
            // char grade = 'A';
            //
            // int maxInt = int.MaxValue;
            //
            // long maxLong = long.MaxValue;
            //
            // decimal maxDec = decimal.MaxValue;
            //
            // float maxFloat = float.MaxValue;
            //
            // double maxDouble = double.MaxValue;
            //
            // Console.WriteLine("Big number " + maxDec);
            //
            // var another_name = "Tom";
            //
            // Console.WriteLine("name is a {0}", another_name.GetTypeCode());
            //
            // #endregion
            //
            // #region math
            //
            // //like Java
            //
            // #endregion
            //
            // #region numbers
            //
            // double num1 = 10.5;
            // double num2 = 33;
            //
            // Console.WriteLine("Math.Max(num1, num2) " + Math.Max(num1, num2));
            //
            // Random random = new Random();
            // Console.WriteLine("Generate random between 1 and 10 " + random.Next(1, 11));
            //
            // #endregion
            //
            // #region if
            //
            // int age = 17;
            //
            // if (age > 5 && age <= 7)
            // {
            //     Console.WriteLine("go to kids garden");
            // }
            // else if (age > 7 && age <= 17)
            // {
            //     Console.WriteLine("Go to school");
            // }
            // else
            // {
            //     Console.WriteLine("Go to work");
            // }
            //
            // #endregion
            //
            // #region ternary
            //
            // int driveAge = 16;
            //
            // bool canDrive = driveAge >= 16 ? true : false;
            //
            // #endregion
            //
            // #region switch
            //
            // int switchAge = 10;
            //
            // switch (switchAge)
            // {
            //     case 0:
            //         Console.WriteLine("Infant");
            //         break;
            //     case 8:
            //     case 9:
            //     case 10:
            //         Console.WriteLine("Pupil");
            //         break;
            //     default:
            //         Console.WriteLine("no data");
            //         break;
            // }
            //
            // #endregion
            //
            // #region loop
            //
            // //while like Java
            // //continue
            // //break
            // //do while
            // //for
            //
            // string randStr = "Some random string";
            // foreach (char c in randStr)
            // {
            //     Console.WriteLine(c);
            // }
            //
            // #endregion
            //
            // #region equals
            //
            // string first = "First value";
            // string second = "Second value";
            // Console.WriteLine("Check equality: '{0}' equals '{1}' is {2}", first, second, first.Equals(second));
            //
            // #endregion
            //
            // #region string
            //
            // string samString = "My sample string";
            // Console.WriteLine("Is empty {0}", samString.Length == 0);
            // Console.WriteLine("Is empty {0}", String.IsNullOrEmpty(samString));
            // Console.WriteLine("Is empty {0}", String.IsNullOrWhiteSpace(samString));
            //
            // Console.WriteLine("Index of bunch " + samString.IndexOf("banch"));
            //
            // //SubString
            // //StarsWith
            // //Trim TrimEnd TrimStart
            // //Replace
            // //Remove(0, 2)
            //
            // string formatted = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);
            // //{0:c} currency
            // //{1:00.00} 
            // //{2:#.00} 
            // //{3:0,0} 
            // Console.WriteLine(formatted);
            //
            //
            // StringBuilder sb = new StringBuilder();
            // sb.Append("This is first sentence");
            // sb.AppendFormat("My name is {0} and I live in {1}", "Oleksii", "Dnipro");
            // sb.Replace("a", "e");
            // sb.Remove(5, 7); //starts from index 5 not including 7
            //
            // string joinStr = string.Join(",", "first", "second");
            // Console.WriteLine(joinStr);
            //
            // #endregion
            //
            //
            // #region array
            //
            // string[] names = new string[3] {"Bob", "Matt", "John"};
            // int[] intArr = {1, 2, 3};
            // Console.WriteLine("Arr len " + intArr.Length);
            // // Console.WriteLine("Null or empty " + );
            //
            // #endregion
            
            // #region list
            //
            // List<int> numList = new List<int>();
            // numList.Add(4);
            // numList.Add(141);
            // numList.Add(111);
            //
            // int[] arr = {1, 3, 4};
            // numList.AddRange(arr);
            // numList.AddRange(new int[] {1, 3, 4});
            //
            // numList.Clear();
            // List<int> numList2 = new List<int>(new int[] {1, 3, 4});
            // numList.Insert(0, 3);
            // numList.Remove(3);
            // numList.RemoveAt(0);
            //
            // //Sort
            // //Contains
            // //IndexOf
            // List<string> strList = new List<string>(new string[] {"Tom", "Bob", "Mike"});
            // Console.WriteLine(strList.Contains("Tom", StringComparer.OrdinalIgnoreCase));
            // //fast init
            // List<int> numListFast = new List<int> {5, 10, 15, 20, 25};
            //
            // #endregion
            //
            // #region exception
            //
            // Console.WriteLine("Enter number");
            // string val = Console.ReadLine();
            // Console.WriteLine("Multiply to..");
            // string multiply = Console.ReadLine();
            // try
            // {
            //     int num = int.Parse(val);
            //     int num_multi = int.Parse(multiply);
            //     Console.WriteLine("Result is " + num * num_multi);
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine("Invalid number");
            // }
            //     
            // //throw
            //
            // #endregion
            //
            //
            // #region key arguments
            //
            // Animal barsik = new Animal("barsik", "nya");
            // barsik.Height = 10;
            // barsik.Weight = 7;
            // barsik.Sound = "nya";
            //
            // Animal murzik = new Animal
            // {
            //     Name = "murzik",
            //     Sound = "nya"
            // };
            //
            // Console.WriteLine("Number of animals = " + Animal.NumOfAnimals);
            //
            // #endregion
            //
            // #region Person
            //
            // Person person = new Person("Joe", "Snow");
            // Console.WriteLine(person.Name);
            //
            // #endregion
            //
            // #region override operator
            //
            // Square s1 = new Square(1);
            // Square s2 = new Square(2);
            // Square s3 = s1 + s2;
            // Console.WriteLine("Square sum = " + s3);
            //
            // #endregion
            //
            // #region generics
            //
            // KeyValue<string, int> keyValue = new KeyValue<string, int>("Friday", 5);
            // keyValue.showData();
            //
            // #endregion
            //
            // #region Enum
            //
            // Temperature temp = Temperature.Boil;
            // printTemp(temp);
            //
            // #endregion
            //
            // #region custom library
            //
            // User user = new User("Mike", 22);
            // user.Display();
            //
            // Employee employee = new Employee("John", 30, "DataArt");
            // employee.Display();
            //
            // #endregion
            //
            // #region Structure
            //
            // string s = "INIT";
            // Console.WriteLine($"s = {s}");
            // string s2 = changeString(s);
            // Console.WriteLine($"s = {s}");
            // Console.WriteLine($"s2 = {s2}");
            //
            // #endregion


            // #region delegate and lambda
            //
            // //anonymous functions
            // Calculate sum = delegate(int one, int two) { return one + two; };
            // //lambda delegate
            // Calculate multi = (one, two) => one * two;
            //
            // //assign to existing function
            // Calculate max = Math.Max;
            //
            // Console.WriteLine($"Sum of 1 and 2 is {sum(1, 2)}");
            // Console.WriteLine($"Multiply of 3 and 4 is {multi(3, 4)}");
            // Console.WriteLine($"Max of 5 and 6 is {max(3, 4)}");
            //
            // #endregion

            // #region Local function
            //
            // int LocalSum()
            // {
            //     return 1 + 2;
            // }
            //
            // //lambda local function
            // int LocalSumLambda() => 1 + 2;
            // int LocalSumFunc(int x, int y) => x + y;
            //
            // //Func
            // Func<int, int, int> sumFunc = (x, y) => x + y;
            // Console.WriteLine($"Sum of 1 and 2 is {sumFunc(1, 2)}");
            //
            //
            // //List
            // List<int> listForLambda = new List<int> {5, 10, 15, 20, 25};
            // List<int> odds = listForLambda.Where(n => n % 2 == 0).ToList();
            // List<int> sqrList = listForLambda.Select(n => n * n).ToList();
            //
            //
            // Console.WriteLine($"Initial list {string.Join(", ",listForLambda)}");
            // Console.WriteLine($"Odds list {string.Join(", ",odds)}");
            // Console.WriteLine($"Sqr list {string.Join(", ",sqrList)}");
            // #endregion

            #region file IO

            string path = "myFile.txt";
            string[] friends = {"Tom", "Bob", "Joe"};
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var friend in friends)
                {
                    sw.WriteLine(friend);
                }
            }

            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            Console.WriteLine(string.Join(", ", lines));
            #endregion
        }

        #region overload

        public static int GetSum(int first = 1, int second = 2)
        {
            return first + second;
        }

        public static double GetSum(double first = 1, double second = 2)
        {
            return first + second;
        }

        #endregion

        public static void printTemp(Temperature temp)
        {
            switch (temp)
            {
                case Temperature.Freeze:
                    Console.WriteLine($"Water is frozen. Temperature is {(int) temp}");
                    break;
                case Temperature.Low:
                    Console.WriteLine($"Water is cold. Temperature is {(int) temp}");
                    break;
                case Temperature.Warm:
                    Console.WriteLine($"Water is warm. Temperature is {(int) temp}");
                    break;
                case Temperature.Boil:
                    Console.WriteLine($"Water is boiling. Temperature is {(int) temp}");
                    break;
            }
        }

        public static string changeString(string s)
        {
            s += " CHANGED";
            return s;
        }
    }
}