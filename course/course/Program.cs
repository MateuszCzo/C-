using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.ClassesExample();
        }

        static void ConsoleExample()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static void VariablesExample()
        {
            String text = "Hello World! ";
            int amount = 1;
            float number = 2.4f;
            char character = ' ';
            double double1;
            decimal number1 = (decimal)1.2;
            double1 = 2.5d;
            bool boolean = true;
            Console.WriteLine(text + amount + character + number + ' ' + double1);
            Console.ReadLine();
        }

        static void StringExample()
        {
            String text = "Lorem ipsum";
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Contains("Lorem"));
            Console.WriteLine(text[0]);
            Console.WriteLine(text.IndexOf('r'));
            Console.WriteLine(text.IndexOf('a'));
            Console.WriteLine(text.Substring(6));
            Console.ReadLine();
        }

        static void NumbersExample()
        {
            Console.WriteLine(5 + 8.1); // decimal
            Console.WriteLine(5 / 2);   // int
            Console.WriteLine(5 / 2f);  // float
            Console.WriteLine(Math.Abs(-1));
            Console.WriteLine(Math.Pow(2, 2));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Max(2,3));
            Console.WriteLine(Math.Min(2,3));
            Console.WriteLine(Math.Round(4.3));
            Console.ReadLine();
        }

        static void UserInputExample()
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }

        static void CalculatorExample()
        {
            Console.WriteLine("Number 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number1 + number2);
            Console.ReadLine();
        }

        static void ArrayExample()
        {
            int[] array = { 1, 2, 3, 4};
            string[] strings = new string[4];
            strings[0] = "test1";
            strings[1] = "test2";

            Console.WriteLine(array[0]);
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings[2]);
            Console.ReadLine();
        }

        static void MethodExample()
        {
            SayHi("Mike");
            Console.WriteLine(Cube(2));
            Console.ReadLine();
        }

        static void SayHi(String name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int Cube(int number)
        {
            return number * number * number;
        }

        static void IfStatementsExample()
        {
            bool boolean = true;
            bool boolean2 = true;
            bool boolean3 = true;

            if (boolean && boolean2)
            {
                Console.WriteLine("1");
            } 
            else if (boolean3)
            {
                Console.WriteLine("2");
            } 
            else
            {
                Console.WriteLine("3");
            }
            Console.ReadLine();
        }

        static void ComparisonsExample()
        {

        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }

            return Math.Max(num1, num2);

            return num1 > num2 ? num1 : num2;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }

            return Math.Max(num1, Math.Max(num2, num3));

            return num1 > num2 && num1 > num3 ? num1 : num2 > num3 ? num2 : num3;
        }

        static void CalculatorExample2()
        {
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter a operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a 2 number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            if (op == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '+')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '/')
            {
                Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine("Unknown operator");
            }
            Console.ReadLine();
        }

        static void SwitchExample()
        {
            Console.WriteLine(GetDay(1));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            // Dictionary
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturdat" };

            // ContainsKey()
            if (dayNum < 0 || dayNum > 6) {
                return "";
            }

            return days[dayNum];

            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturdat";
                    break;
                default:
                    dayName = "";
                    break;
            }

            return dayName;
        }

        static void LoopsExample()
        {
            //for, foreach, while, do while, recursive functiion
            int[] nums = { 1, 2, 3 };

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine(i);
            }

            foreach (int num in nums) {
                Console.WriteLine(num);
            }

            int index = 1;
            while (index <= 5) {
                Console.WriteLine(index++);
            }

            do {
                Console.WriteLine(--index);
            } while (index > 1);

            Console.ReadLine();
        }

        static void ArrayExample2()
        {
            int[,] nums = { 
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            };

            for (int i = 0; i < nums.GetLength(0); i++) { 
                for (int j = 0; j < nums.GetLength(1); j++) {
                    Console.WriteLine(nums[i, j]);
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        ///     Comment Example
        /// </summary>
        /// 
        /// <param name="num">number</param>
        /// 
        /// <returns>void</returns>
        /// 
        /// <example>
        ///     <code>
        ///         CommentsExample(2);
        ///     </code>
        /// </example>
        static void CommentsExample(int num)
        {
            // comment
            /*
            comment
            */
        }

        static void ExceptionExample()
        {
            try {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = num1 / 0;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Final");
            }
            Console.ReadLine();
        }

        static void ClassesExample()
        {
            Book book = new Book("Author", "Title", 1);

            Console.WriteLine(Book.getBookCount());

            Console.WriteLine(book.ToString());
            Console.ReadLine();
        }

        static void CollectionsExample()
        {
            // array
            int[] array = new int[5];

            // sets & maps - unique values

            // System.Collection

            ArrayList arrayList = new ArrayList();

            Stack<int> stack = new Stack<int>();

            Queue<int> queue = new Queue<int>();

            Hashtable hashTable = new Hashtable();

            // System.Collection.Generic

            List<int> list = new List<int>();

            // Stack<int> stack = new Stack<int>();

            // Queue<int> queue = new Queue<int>();

            LinkedList<int> linkedList = new LinkedList<int>();

            HashSet<int> hashSet = new HashSet<int>();

            SortedSet<int> sortedSet = new SortedSet<int>();

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            SortedList<int, string> sortedList = new SortedList<int, string>();

            // System.Collection.Non-Generic

            BlockingCollection<int> blockingCollection = new BlockingCollection<int>();

            ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();

            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();

            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();

            // interfaces

            IList iList = new List<int>();
        }
    }
}
