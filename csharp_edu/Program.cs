using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_edu
{
    class Program
    {
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

            // #region ternary
            //
            // int driveAge = 16;
            //
            // bool canDrive = driveAge >= 16 ? true : false;
            //
            // #endregion

            // #region swithch
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
            //
            // #endregion

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


            Animal animal = new Animal("barsik");

        }
    }
}