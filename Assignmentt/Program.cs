using System.Collections;

namespace Assignmentt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var intRange = new Range<int>(5, 15);
            //Console.WriteLine(intRange.IsInRange(10)); 
            //Console.WriteLine(intRange.IsInRange(20)); 
            //Console.WriteLine(intRange.Length());      

            //var doubleRange = new Range<double>(1.5, 4.5);
            //Console.WriteLine(doubleRange.IsInRange(3.2));
            //Console.WriteLine(doubleRange.Length());
            #endregion

            #region Q2
            //ArrayList myList = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original list:");
            //foreach (var item in myList)
            //    Console.Write(item + " "); 

            //Reverser.ReverseArrayList(myList);

            //Console.WriteLine("\nReversed list:");
            //foreach (var item in myList)
            //    Console.Write(item + " ");
            #endregion

            #region Q3
            //{
            //    List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };

            //    List<int> evens = EvenNumberFilter.GetEvenNumbers(input);

            //    Console.WriteLine("Even numbers:");
            //    foreach (int num in evens)
            //    {
            //        Console.Write(num + " "); 
            //    }
            //}
            #endregion

            #region Q4
            //{
            //    try
            //    {
            //        FixedSizeList<string> list = new FixedSizeList<string>(3);

            //        list.Add("apple");
            //        list.Add("banana");
            //        list.Add("cherry");

            //        Console.WriteLine(list.Get(0)); 
            //        Console.WriteLine(list.Get(2)); 

                    
            //        list.Add("date");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }

            //    try
            //    {
            //        FixedSizeList<int> nums = new FixedSizeList<int>(2);
            //        nums.Add(10);
            //        nums.Add(20);
            //        Console.WriteLine(nums.Get(5)); 
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //}
            #endregion

            #region Task 01
            //var bananaRange = new BananaRipenessRange<int>(5, 8);

            //Console.WriteLine(bananaRange.IsPerfectBanana(7)); 
            //Console.WriteLine(bananaRange.IsPerfectBanana(3)); 
            //Console.WriteLine(bananaRange.IsPerfectBanana(8)); 
            //Console.WriteLine(bananaRange.IsPerfectBanana(9)); 

            //var floatBananaRange = new BananaRipenessRange<float>(4.5f, 7.2f);
            //Console.WriteLine(floatBananaRange.IsPerfectBanana(6.8f));
            //Console.WriteLine(floatBananaRange.IsPerfectBanana(4.4f));
            #endregion

            #region Task 02
            var stringBox = new MultiBox<string>();

            Console.WriteLine(stringBox.IsEmpty());

            stringBox.InsertItem("Book");
            stringBox.InsertItem("Tablet");

            Console.WriteLine(stringBox.Count());   
            Console.WriteLine(stringBox.IsEmpty()); 

            var items = stringBox.GetAllItems();
            Console.WriteLine("Items in the box:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
    }
    
}
