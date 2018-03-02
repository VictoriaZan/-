using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleArrays();
            //ArrayOfObjects();
            //JaggedMultidimensionalArray();
            //RectMultidemensionArray();
            //PrintPrintArray();
            //PrintGetStringArray();
        }

        static void SimpleArrays()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
                Console.WriteLine(i);
            
            string[] booksOnDotNet = new string[] {"one", "two", "three" };
            Console.WriteLine("stringArray contains {0} elements.", booksOnDotNet.Length);

            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray contains {0} elements.", boolArray.Length);

            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intlArray contains {0} elements.", intArray.Length);
        }
        static void ArrayOfObjects()
        {
            Object[] myObject = new object[4];
            myObject[0] = 10;
            myObject[1] = false;
            myObject[2] = new DateTime(1969, 3, 11);
            myObject[3]=  "Form and Void";

            foreach(object obj in myObject)
            Console.WriteLine("Type of element: {0}, Value: {1}", obj.GetType(), obj);
        }

        static void JaggedMultidimensionalArray()
        {
            int[][] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            for(int i = 0; i<5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j]+" ");
                Console.WriteLine();
            }
        }

        static void RectMultidemensionArray()
        {
            int[,] myMatrix;
            myMatrix = new int[6, 6];

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;

            for (int i=0; i<6; i++)
                for(int j=0; j<6; j++)
                    Console.Write(myMatrix[i,j]+"\t");
            Console.WriteLine();
        }

        static void PrintArray(int[] arr)
        {
            for(int i = 0; i< arr.Length; i++)
                Console.WriteLine("Index: {0}, Value: {1}", i, arr[i]);
        }
        static string[] GetSringArray()
        {
            string[] theStrings = { "Hello", "from", "Charlotte" };
            return theStrings;
        }

        static void PrintPrintArray()
        {
            int[] arr = { 1, 2, 8, 9, 6, 3, 44, 45 };
            PrintArray(arr);
        }
        static void PrintGetStringArray()
        {
            string[] arr = GetSringArray();
            foreach(string str in arr)
                Console.WriteLine(str);
        }

    }
}
