using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace ConsoleApp1
{
    class Program
    {

        static void DispplayMessage()
        {
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }
        static void Main(string[] args)
        {
            /*string[] theArgs = Environment.GetCommandLineArgs();
            foreach(string arg in args)
            {
            Console.WriteLine("ARG:{0}", arg);
            }
            Console.ReadLine();
            */
            // ShowEnviromentDetails();
            // Console.Beep(500,4567);
            //ParseFromString();
            //DispplayMessage();
            // UseDatesAndTimes();
            //UseBigInteger();
            //BasicStringsFunctionality();
            //StringEquality();
            //Console.WriteLine(getCharCount("а", "МолАко")); 
            //Console.WriteLine(ChangeCase("ИзМеНиТь симвоЛы"));
            //Console.WriteLine(IsContains("adf","sdf"));
            //Comparing("МАМА мыла раму", "мама мыла раму", true);
            // Console.WriteLine(ReturnCount("Мама Мыла автомоб ОЛД ол"));
            // ProcessesBytes();
            //DeclareImplictVars();
            //LinqOverInts();
            //WhileLoop();
            //Recall();
            //Call();
            //Res();
            //RecallLogData();
            //RecallFancyColor();
            AddRecall();
        }

        static int Add(int a, int b)
        { return a + b; }

        static long Add(long a, long b)
        { return a + b; }

        static double Add(double a, double b)
        { return a + b; }

        static void AddRecall()
        {
            Console.WriteLine(Add(10,10));
            Console.WriteLine(Add(90000000000,9000000000));
            Console.WriteLine(Add(4.4,3.3));
        }
    // SYSTEM.ENVIRONMENT
        private static void ShowEnviromentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}",drive);

            Console.WriteLine("Is 64-bit?: {0}",Environment.Is64BitOperatingSystem);
            Console.WriteLine("Machine Name is: {0}",Environment.MachineName);
            Console.WriteLine("User Domain Name is: {0}", Environment.UserDomainName);
            /*
            Console.WriteLine("OS: {}", Environment.OSVersion);
             */
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);       
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.WriteLine("Current Directory: {0}", Environment.CurrentDirectory);
            Console.WriteLine("System Directory: {0}", Environment.SystemDirectory);
            Console.WriteLine("System page size: {0}",Environment.SystemPageSize);
            Console.WriteLine("Time: {0:X}",Environment.TickCount);
            Console.WriteLine("Working Set {0}",Environment.WorkingSet);
            Console.WriteLine("Has ShutDown Started?: {0}", Environment.HasShutdownStarted);
            Console.WriteLine("Exit Code: {0}", Environment.ExitCode);
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Environment Variables: {0}", Environment.GetEnvironmentVariables());
        }

       // SHOWS OUTPUT FORMATS
        static void OutputFormat()
        {
            int digit = 99999;
            Console.WriteLine("c format: {0:c}", digit);
            Console.WriteLine("d9 format: {0:d9}", digit);
            Console.WriteLine("f3 format: {0:f3}", digit);
            Console.WriteLine("n format: {0:n}", digit);
            Console.WriteLine("E format: {0:E}", digit);
            Console.WriteLine("e format: {0:e}", digit);
            Console.WriteLine("X format: {0:X}", digit);
            Console.WriteLine("x format: {0:x}", digit);
        }

        //SHOWS A WORK WITH "PARSE"
        static void ParseFromString()
        {
            Console.WriteLine("_____________________________");
            bool b = bool.Parse("true");
            Console.WriteLine("Parse to boolean: {0}",b);

            /*double d = double.Parse("99.369");
            Console.WriteLine("Parse to double: {0}",d);*/

            int i = int.Parse("4");
            Console.WriteLine("Parse to int: {0}",i);

            char c = char.Parse("H");
            Console.WriteLine("Parse to char: {0}",c);
        }

        //WORK WITH DATE AND TIME
        static void UseDatesAndTimes()
        {
            Console.WriteLine("_________________________________");
            DateTime dt = new DateTime(2011, 10, 17);
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            TimeSpan ts = new TimeSpan(4,30,0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
        }

        //USING BIG INTEGER
        static void UseBigInteger()
        {
            BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999999999998");
            Console.WriteLine(biggy);
            Console.WriteLine("Is Even?: {0}",biggy.IsEven);
            Console.WriteLine("Is a power of two?: {0}",biggy.IsPowerOfTwo);

            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("888888888888888888888888888888888888888"));
            Console.WriteLine(reallyBig);
        }

        //STRINGS

        static void BasicStringsFunctionality()
        {
            string firstName = "Victoria";
            string str = " is lapochka!";
            Console.WriteLine("Value of firstName: {0}", firstName.Length);
            Console.WriteLine("In uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("In lower: {0}", firstName.ToLower());
            Console.WriteLine("Is contains the letter V?: {0}", firstName.Contains("V"));
            Console.WriteLine("Replace: {0}",firstName.Replace("ia",""));


            firstName = firstName + str;
            Console.WriteLine(firstName);

            firstName = String.Concat(firstName, firstName.Replace("a", "o"));
            Console.WriteLine(firstName);

            string strWithTabs = "La\tLaLa\tLaLaLaaaaa\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine(@"C:\MyApp\bin\Debug");
            string myLongString = @"This is a very
            ""very
                very  ""  
                    long string";
            Console.WriteLine(myLongString);
        }

        static void StringEquality()
        {
            string s1 = "Hello!", s2 = "Yo!";
            Console.WriteLine("s1 = {0}",s1);
            Console.WriteLine("s2 = {0}",s2);

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
        }
        //1
        ////Разработайте функцию getCharCount которая принимает символ и строку
        ////и возвращает количество таких символов в строке
        ////если вместо символа передана строка, то в качестве символа используется первый символ этой строки.
        ////регистр значения не имеет

        static int getCharCount(string a, string b)
        {   int result = 0;
            char[] str = b.ToLower().ToCharArray();
            char[] symb = a.ToLower().ToCharArray();
            foreach (char c in str)
            {
                if (c == symb[0])
                    result++;
             }
            return result;
        }


        //2
        ////Разработайте функцию changeCase, которая принимает строку как аргумент 
        ////в полученной строке заменяем регистр у каждого из символов
        ////Например changeCase("Строка") -- "сТРОКА"

     static string ChangeCase(string str)
        {
            char[] charStr = str.ToCharArray();
            for (int i = 0; charStr.Length > i; i++)
            {
                if (char.IsUpper(charStr[i]))
                {
                    charStr[i] = char.ToLower(charStr[i]);
                }
                else charStr[i] = char.ToUpper(charStr[i]);
            }
            string result = new string(charStr);
            return result;
        }

        //3
        ////Разработайте функцию contains, которая принимает 2 строки в качестве аргументов
        ////функция возвращает true, если втророй аргумент является подстрокой первого аргумента
        ////null если один или оба аргумента -- пустые строки
        ////иначе false

        static string IsContains(string a, string b)
        {
            string result = "";
            if (true == (a.Contains(b)))
            {
                if (a == "" || b == "")
                {
                    result = "null";
                    return result;
                }
                result = "true";
                return result;
            }
            else
            {
                result = "false";
                return result; 
            };
        }

        //4
        ////Разработайте функцию contains, которая принимает 2 строки в качестве аргументов
        ////функция возвращает количество вхождений второй строки в первую
        ////если одна из строк пустая то 0



        //5
        ////Разработайте функцию Compare, которая производит сравнение строк с учетом или без учета регистра
        ////параметры 1 и 2 - это сравниваемые строки. Параметр 3 логический флаг
        ////true -- регистр учитывается, false -- нет

        static void Comparing(string a, string b, bool flag)
        {
         Console.WriteLine(" Is string {0} == {1}?: {2} ",a,b, string.Compare(a,b,flag)); 
        }

        //8) Реализовать функцию, которая принимает строку и возвращает количество слов, начинающихся с прописной буквы.
        static int ReturnCount(string a)
        {
            int result = 0;
            char[] cStr = a.ToCharArray();
            for (int i =0; cStr.Length > i; i++)
            {
                if (char.IsUpper(cStr[i]) && (cStr[i - 1] == ' ' || i == 0))
                { result++; }
            }
            return result;
        }

        static void ProcessesBytes()
        {
            byte b1 = 100, b2 = 250;
            try
            {
                byte res = unchecked((byte)Add(b1, b2));
                //Console.WriteLine("{0} + {1} = {2}",b1,b2,(Add(b1,b2)));
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       

        static void DeclareImplictVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time...";
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }
        static void LinqOverInts()
        {
            int[] numbers = { 10, 20, 30, 1, 2, 3 };
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach(var i in subset)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("subset is a {0}",subset.GetType().Name);
            Console.WriteLine("subset is defined in {0}", subset.GetType().Namespace);
        }

        static void WhileLoop()
        {
            string userIdDone = "";
            while (userIdDone.ToLower() != "yes")
            {
                Console.WriteLine("Are you done? [yes/no]: ");
                userIdDone = Console.ReadLine();
            }
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
        static void Recall()
        {
            int i;
            string str;
            bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Bool is: {0}", b);
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempString = s1;
            s1 = s2;
            s2 = tempString;
        }

        static void Call()
        {
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
        }

        static double CalculateParams(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }

        static void Res()
        {
            double a = CalculateParams(1.0,4.5,66);
            Console.WriteLine("Average: {0}",a);
        }
        static void LogData(string message, string owner = "Programmer")
        {
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }
        static void RecallLogData()
        {
            LogData("Oh no!! I'm hungry!");
            LogData("I want to eat!", "Jenny");
        }

        static void ConsoleColorFancyMessage(ConsoleColor textColor, string message, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroungColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroungColor;
        }
        static void RecallFancyColor()
        {
            ConsoleColorFancyMessage(message: "Wow! Very fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);
            ConsoleColorFancyMessage(ConsoleColor.Blue, message: "Wow");
        }

    }
}
