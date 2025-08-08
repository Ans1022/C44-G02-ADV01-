using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper 
    {

        public static void BubleSort<T>( T [] arr, IComparer<T> comparer ) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        if (comparer.Compare(arr[j], arr[j+1]) > 0)
                            Swep(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }



        #region Non Generice Bublesort
        //public static void BubleSort(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length -1 ; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                    Swep(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //} 
        #endregion

        // Generics SWEP Method 
        public static void Swep<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
        #region non Generics
        //public static void Swep(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swep(ref double X, ref double Y)
        //{
        //    double temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        //public static void Swep(ref Point X, ref Point Y)
        //{
        //    Point temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion


        #region Non Generics LeanerSearach
        //public static int LinerSearach(int[] arr, int Value)

        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == Value)
        //            {
        //                return i;

        //            }
        //        }
        //    }
        //    return -1;
        //} 
        #endregion

        #region  Generics Liner Sceaher
        public static int LinerSearach<T>(T[] arr, T Value)

        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(Value))
                    {
                        return i;

                    }
                }
            }
            return -1;
        }
        public static int LinerSearach<T>(T[] arr, T Value, IEqualityComparer<T> equalityComparer )

        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (equalityComparer.Equals(arr[i],Value)) return i;
                    
                }
            }
            return -1;
        }
        #endregion

        public static void PrintArray<T>(T[] array)
        {
            foreach (T i in array)
            {
                Console.WriteLine($"I : {i}");
            }
            Console.WriteLine();
        }

    }
}
