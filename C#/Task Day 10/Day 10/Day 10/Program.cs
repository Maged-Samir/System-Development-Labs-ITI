using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using static Day_10.ListGenerators;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            #region LINQ - Restriction Operators

            ////1. Find all products that are out of stock.
            //var Result = ProductList.Where(p => p.UnitsInStock == 0);

            ////2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result1 = ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00M);


            //foreach (var item in Result1)
            //{
            //    Console.WriteLine(item);
            //}

            ////3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digits = Arr.Where((digit, index) => digit.Length < index);

            //foreach (var item in digits)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region LINQ - Element Operators

            ////1.Get first Product out of Stock
            //var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(Result);

            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result1 = ProductList.FirstOrDefault(p => p.UnitPrice > 1.000M);
            //Console.WriteLine(Result1);

            ////3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result2 = Arr.Where(e => e > 5).ElementAt(1);
            //Console.WriteLine(Result2); 

            #endregion


            #region LINQ - Set Operators

            ////1.Find the unique Category names from Product List
            //var Result03 = ProductList.Select(p => p.Category).Distinct();

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}

            ////2.Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result031 = ProductList.Select(p => p.ProductName[0]);
            //var Result032 = CustomerList.Select(c => c.CompanyName[0]);

            //var OurSeq = Result031.Union(Result032);

            //foreach (var item in OurSeq)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Intersect");
            ////3.Create one sequence that contains the common first letter from both product and customer names

            //var OurSeq1 = Result031.Intersect(Result032);

            //foreach (var item in OurSeq1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Except");
            ////4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var OurSeq2 = Result031.Except(Result032);

            //foreach (var item in OurSeq2)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

             
            #region LINQ - Aggregate Operators

            ////1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result041 = Arr.Count(e => e % 2 == 1);
            //Console.WriteLine(Result041);

            ////2.Return a list of customers and how many orders each has.
            //var Result042 = CustomerList.Select(c => new { c.CustomerID, OrderCount = c.Orders.Count() });

            ////foreach (var item in Result042)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////3. Return a list of categories and how many products each has
            //var Result043 = ProductList.GroupBy(p => p.Category).Select(c => new { category = c.Key, productcount = c.Count() });

            ////foreach (var item in Result043)
            ////{
            ////    Console.WriteLine(item);
            ////}


            ////4.Get the total of the numbers in an array.
            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Summition = Arr1.Sum();
            //Console.WriteLine(Summition);

            //// 5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            string[] Mydictionary = File.ReadAllLines(@"G:\ITI-9 Months\19-LINQ\Day 01\Assignment Files\dictionary_english.txt");
            //var totalChars = Mydictionary.Sum(w => w.Length);
            //Console.WriteLine(totalChars);

            ////6.Get the total units in stock for each product category.
            //var Result046 = ProductList.GroupBy(p => p.Category).Select(c => new { category = c.Key, TotalUnitsInStock = c.Sum(p => p.UnitsInStock) });

            //foreach (var item in Result046)
            //{
            //    Console.WriteLine(item);
            //}

            ////7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var shortestWord = Mydictionary.Min(w => w.Length);
            //Console.WriteLine(shortestWord);

            ////8.Get the cheapest price among each category's products
            //var Result048 = ProductList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, CheapestPrice = c.Min(p => p.UnitPrice) });
            //foreach (var item in Result048)
            //{
            //    Console.WriteLine(item);
            //}

            ////9.Get the products with the cheapest price in each category(Use Let)

            //var Result049 =
            //from p in ProductList
            //group p by p.Category into g
            //let minPrice = g.Min(p => p.UnitPrice)
            //select new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == minPrice) };

            //foreach (var item in Result049)
            //{
            //    Console.WriteLine(item);
            //}

            ////10.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var longestLength = Mydictionary.Max(w => w.Length);
            //Console.WriteLine(longestLength);

            ////11.Get the most expensive price among each category's products.

            //var Result0411 = ProductList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, MostExpensivePrice = c.Max(p => p.UnitPrice) });
            //foreach (var item in Result0411)
            //{
            //    Console.WriteLine(item);
            //}

            ////12.Get the products with the most expensive price in each category.
            //var Result0412 =
            //from p in ProductList
            //group p by p.Category into c
            //let maxPrice = c.Max(p => p.UnitPrice)
            //select new { Category = c.Key, MostExpensiveProducts = c.Where(p => p.UnitPrice == maxPrice) };

            //foreach (var item in Result0412)
            //{
            //    Console.WriteLine(item);
            //}

            ////13.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //var averageLength = Mydictionary.Average(w => w.Length);
            //Console.WriteLine(averageLength);

            ////14.Get the average price of each category's products.

            //var Result0414 = ProductList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, AveragePrice = c.Average(p => p.UnitPrice) });

            //foreach (var item in Result0414)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region LINQ - Ordering Operators

            ////1.Sort a list of products by name
            //var Result015 = ProductList.OrderBy(p => p.ProductName).Select(c => new { c.ProductName });
            //foreach (var item in Result015)
            //{
            //    Console.WriteLine(item);
            //}

            ////2.Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result025 = Arr2.OrderBy(a => a, new CaseInsensitiveComparer());
            //foreach (var item in Result025)
            //{
            //    Console.WriteLine(item);
            //}

            ////3.Sort a list of products by units in stock from highest to lowest.

            //var Result035 = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in Result035)
            //{
            //    Console.WriteLine(item);
            //}

            ////4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr09 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result045 = Arr09.OrderBy(e => e.Length);

            //      foreach (var item in Result045)
            //{
            //    Console.WriteLine(item);
            //}

            ////5.Sort first by word length and then by a case-insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result055 =words.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());

            //foreach (var item in Result055)
            //{
            //    Console.WriteLine(item);
            //}

            ////6.Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result065 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in Result065)
            //{
            //    Console.WriteLine(item);
            //}

            ////7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr22 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result075 = Arr22.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());

            //foreach (var item in Result075)
            //{
            //    Console.WriteLine(item);
            //}


            ////8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr33 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result085 = Arr33.Where(e => e[1]=='i').Reverse();

            //foreach (var item in Result085)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region LINQ - Partitioning Operators

            //1.Get the first 3 orders from customers in Washington

            //var Result016 = (
            //from c in CustomerList
            //from o in c.Orders
            //where c.Region == "Washington"
            //select new { c.CustomerID, o.OrderID}).Take(3);

            //foreach (var item in Result016)
            //{
            //    Console.WriteLine(item);
            //}

            ////2.Get all but the first 2 orders from customers in Washington.

            //var Result026 = Result016.Skip(2);

            //foreach (var item in Result026)
            //{
            //    Console.WriteLine(item);
            //}

            ////3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result036 = numbers.TakeWhile((n, i) => n >= i);

            //foreach (var item in Result036)
            //{
            //    Console.WriteLine(item);
            //}

            ////4.Get the elements of the array starting from the first element divisible by 3.


            //int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result046 = numbers1.SkipWhile(n => n % 3 != 0);
            //foreach (var item in Result046)
            //{
            //    Console.WriteLine(item);
            //}

            ////5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result056 = numbers3.SkipWhile((n, i) => n >= i);

            //foreach (var item in Result056)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region LINQ - Projection Operators

            ////1.Return a sequence of just the names of a list of products.

            //var Result017 = ProductList.Select(p => new { p.ProductName });

            //foreach(var Product in Result017) 
            //{
            //    Console.WriteLine(Product);
            //}

            ////2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result027 = words.Select(w => new { upper=w.ToUpper() ,lower=w.ToLower() });

            //foreach (var Product in result027)
            //{
            //    Console.WriteLine(Product);
            //}

            ////3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result037 = ProductList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });

            //foreach (var Product in Result037)
            //{
            //    Console.WriteLine(Product);
            //}


            ////4.Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result047 = Arr.Select((num, i) => new { Num = num, InPlace = (num == i) });

            //foreach (var Product in Result047)
            //{
            //    Console.WriteLine(Product);
            //}

            ////5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result057 =
            //from a in numbersA
            //from b in numbersB
            //where a < b
            //select new { a, b };

            //foreach (var item in Result057)
            //{
            //    Console.WriteLine("",item.a,item.b);
            //}

            ////6.Select all orders where the order total is less than 500.00.


            //var Result067 =
            //    from c in CustomerList
            //    from o in c.Orders
            //    where o.Total < 500.00M
            //    select new { c.CustomerID, o.OrderID, o.Total };

            //foreach (var item in Result067)
            //{
            //    Console.WriteLine(item);
            //}


            ////7.Select all orders where the order was made in 1998 or later.

            //var Result077 =
            //from c in CustomerList
            //from o in c.Orders
            //where o.OrderDate >= new DateTime(1998, 1, 1)
            //select new { c.CustomerID, o.OrderID, o.OrderDate };

            //foreach (var item in Result077)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region LINQ - Grouping Operators

            ////1.Use group by to partition a list of numbers by their remainder when divided by 5

            //int[] Arrr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result018 = Arrr.GroupBy(e => e % 5).Select(x => new { Remainder = x.Key, Numbers = x });

            //foreach (var item in Result018)
            //{
            //    Console.WriteLine($"....{item.Remainder}");
            //    foreach (var n in item.Numbers)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            ////2.Uses group by to partition a list of words by their first letter.
            ////Use dictionary_english.txt for Input

            //var Result028 = Mydictionary.GroupBy(w => w[0]).Select(w=> new { FirstLetter = w.Key, Words = w });

            //foreach (var w in Result028)

            //{
            //    foreach (var item in w.Words)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            #endregion


            #region LINQ - Quantifiers

            ////1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //var Result019 = Mydictionary.Any(w => w.Contains("ei"));
            //Console.WriteLine(Result019);

            ////2.Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result029 = ProductList.GroupBy(p => p.Category).Where(p => p.Any(p => p.UnitsInStock == 0))
            //    .Select(p => new { Category = p.Key, Products = p });

            //foreach (var item in Result029)
            //{
            //    Console.WriteLine(item);
            //}

            ////3.Return a grouped a list of products only for categories that have all of their products in stock.

            //var result039 = ProductList.GroupBy(p => p.Category).Where(p => p.All(p => p.UnitsInStock > 0))
            //    .Select(p => new { Category = p.Key, Products = p });

            //foreach (var item in result039)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion



        }

    }
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}