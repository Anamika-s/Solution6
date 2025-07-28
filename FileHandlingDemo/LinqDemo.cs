using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    internal class LinqDemo
    {
        static void Main()
        {
            int[] num = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            // want to get data
            // Linq
            // synatx 
            // var res = from range_variable select array/collection  
            // select range_variable


            // LINQ queries run in 2 ways 
            // 1. Lazy loading > defers laoding values until you iterate
            // 2. Eager loading ? we use some function, the result will get stored in the var

            // call some function
            var res = from temp in num
                      select temp;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            res = (from temp in num
                   select temp).ToList();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            // print sum of the array
            int sum = (from temp in num
                       select temp).ToList().Sum();
            Console.WriteLine("Sum is " + sum);

            double avg = (from temp in num
                       select temp).ToList().Average();
            Console.WriteLine("Avg is " + avg);

            int min = (from temp in num
                       select temp).ToList().Min();
            Console.WriteLine("Min is " + min);

            var evennums = (from temp in num
                            where temp%2==0
                            select temp).ToList();
            Console.WriteLine("Even numbers are ");
            foreach (var item in evennums)
            {
                Console.WriteLine(item);
            }

            var oddnums = (from temp in num
                            where temp % 2 != 0
                            select temp).ToList();
            Console.WriteLine("Odd numbers are ");
            foreach (var item in oddnums)
            {
                Console.WriteLine(item);
            }


            List<int> list = new List<int>() { 2, 6, 3 };
            min = (from temp in list
                   select temp).ToList().Min();



            List<string> names = new List<string>()
            {  "deepak kumar", "anjali kumar", "prasad", "deepak kumar", "pawandeep"};

            var listnames = (from x in names
                             select x).ToList();

            Console.WriteLine("names are ");
            foreach (var item in listnames)
            {
                Console.WriteLine(item);
            }

            var search = (from x in names
                          where x.Contains("deepak kumar")
                          select x).First();
            Console.WriteLine("NAme is found " + search);


            search = (from x in names
                          where x.Contains("deepti kumar")
                          select x).FirstOrDefault();
            Console.WriteLine("NAme is found " + search);
            var listwithkumarnames = (from x in names
                                      where x.Contains("kumar")
                             select x).ToList();

            Console.WriteLine("");
            Console.WriteLine("names are ");
            foreach (var item in listwithkumarnames)
            {
                Console.WriteLine(item);
            }

            // METHOD SYNTAX


            num = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            // want to get data
            // Linq
            // Method synatx 
            // var res = collection/array name .()  


            // LINQ queries run in 2 ways 
            // 1. Lazy loading > defers laoding values until you iterate
            // 2. Eager loading ? we use some function, the result will get stored in the var

            // call some function
             res = num.ToList();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            sum = num.ToList().Sum();
            Console.WriteLine("sum is "+ sum);

            avg= num.ToList().Average();

           listnames=  names.ToList();

            search = names.Where(x => x.Contains("Deepak Kumar")).FirstOrDefault();
            listwithkumarnames = names.Where(x => x.Contains("kumar")).ToList();






















        }
    }
}
