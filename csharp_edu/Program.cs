using System;

namespace csharp_edu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region console
            
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            
            #endregion

            #region data types
            
            bool canVote = true;
            
            char grade = 'A';

            int maxInt = int.MaxValue;

            long maxLong = long.MaxValue;
            
            decimal maxDec = decimal.MaxValue;

            float maxFloat = float.MaxValue;

            double maxDouble = double.MaxValue;

            Console.WriteLine("Big number " + maxDec);

            var another_name = "Tom";
            
            Console.WriteLine("name is a {0}", another_name.GetTypeCode());
            
            #endregion
            
            #region math
            
            //like Java
            
            #endregion
        }
    }
}