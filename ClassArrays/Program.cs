using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {1,234,65,75,23,65,235,12,543,64,77,47,9,62,33 };
            string[] strArray = {"Word","Mama","Window","Text","Jenny","Cat","Boul","Lamp","Integer","Charlotte","states","corns","contains" };
            Object[] objArray = {"Array", 10, 11.5f, 'N', strArray };

            Array.Resize<int>(ref intArray, intArray.Length + 2);
            foreach(int i in intArray)
                Console.Write("{0}  ",i);
            var v = 12.99;
            Array arr = Array.CreateInstance(v.GetType(), 5);
            Console.WriteLine();
            Console.WriteLine(arr.GetType());

            /* //properties

             IsFixed(intArray);
             IsFixed(strArray);
             IsFixed(objArray);

             IsReadInly(intArray);
             IsReadInly(strArray);
             IsReadInly(objArray);

             Console.WriteLine("IsSyncronized: {0}", objArray.IsSynchronized);
             Console.WriteLine("LongLength: {0}", intArray.LongLength);
             Console.WriteLine("Rank: {0}", strArray.Rank);
             Console.WriteLine("SyncRoot: {0}", intArray.SyncRoot.ToString());

             //Binary Search
             Console.WriteLine("Binary Search: {0}", Array.BinarySearch(intArray,12));
             //As Read Only
             //ReadOnlyArr(strArray);
             //Clone
             Clone(intArray);
            CopyTo(objArray);*/
            //Array3D();

        }

        static void IsFixed(Array arr)
        {
            bool res = arr.IsFixedSize;
            Console.WriteLine("{0}", res);
        }
        static void IsReadInly(Array arr)
        {
            bool res = arr.IsReadOnly;
            Console.WriteLine("{0}", res);
        }

        static void ReadOnlyArr(string[] arr)
        {
            foreach(var elem in arr)
                Console.WriteLine(elem);

            IList<String> myList = Array.AsReadOnly(arr);

            try
            {
                myList[3] = "CHANGED";
            }
            catch (NotSupportedException e){
                Console.WriteLine("{0}-{1}", e.GetType(), e.Message);
                Console.WriteLine();
            }

            Console.WriteLine("Through the wrappers: ");
            foreach(var l in myList)
                Console.WriteLine(l);

            arr[3] = "Changed";
            Console.WriteLine("In array, without \"Read only\"");
            foreach(var el in arr)
                Console.WriteLine(el);
        }

        static void Clone(int[] arr)
        {
            int[] clone = (int[])arr.Clone();
            Console.WriteLine("Original array before changing: \n");
            foreach(int i in arr)
                Console.Write("{0} ",i);
            Console.WriteLine();

            Console.WriteLine("Cloned array before changing: \n");
            foreach (int c in clone)
                Console.Write("{0} ",c);
            Console.WriteLine();

            clone[0] = 999;

            Console.WriteLine("Original array after changing: \n");
            foreach (int i in arr)
                Console.Write("{0} ", i);
            Console.WriteLine();

            Console.WriteLine("Cloned array after changing: \n");
            foreach (int c in clone)
                Console.Write("{0} ", c);

        }
        static void CopyTo(Object[] arr)
        {
            int[] insert = { 1, 2, 3 };
            foreach(var obj in arr)
                Console.Write("{0}  ",obj);
            Console.WriteLine();

            insert.CopyTo(arr, 2);

            foreach(var obj in arr)
                Console.Write("{0}  ", obj);
            Console.WriteLine();
        }
        static void Array2D()
        {
            Array my2DArray = Array.CreateInstance(typeof(string), 4, 7);
            try
            {
                for (int i = my2DArray.GetLowerBound(0); i <= my2DArray.GetUpperBound(0); i++)
                    for (int j = my2DArray.GetLowerBound(1); j <= my2DArray.GetUpperBound(1); j++)
                        my2DArray.SetValue("abc" + i + j, i, j);
            }
            catch (Exception e) { Console.WriteLine("{0}   {1}",e.GetType(), e.Message); }

            PrintValues(my2DArray);
        }
        static void Array3D()
        {
            Array my3DArray = Array.CreateInstance(typeof(string), 4, 7,3);
            try
            {
                for (int i = my3DArray.GetLowerBound(0); i <= my3DArray.GetUpperBound(0); i++)
                    for (int j = my3DArray.GetLowerBound(1); j <= my3DArray.GetUpperBound(1); j++)
                        for(int h = my3DArray.GetLowerBound(2); h<=my3DArray.GetUpperBound(2); h++)
                            my3DArray.SetValue("abc" + i + j+h, i, j,h);
            }
            catch (Exception e) { Console.WriteLine("{0}   {1}", e.GetType(), e.Message); }

            PrintValues(my3DArray);
        }
        static void PrintValues(Array arr)
        {
            IEnumerator myEnum = arr.GetEnumerator();
            int i = 0;
            int cols = arr.GetLength(arr.Rank - 1);
            while (myEnum.MoveNext())
            {
                if (i < cols)
                    i++;
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}",myEnum.Current);
            }
            Console.WriteLine();
        }

    }
}
