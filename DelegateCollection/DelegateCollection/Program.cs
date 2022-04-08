using DelegateCollection.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DelegateCollection
{
    class Program
    {
        //public delegate R Check<in T,out R>(T p1);
        //public delegate R Check<in T1,in T2,out R>(T1 p1,T2 p2);
        //public delegate int Check1(string p1);
        //public delegate void Info<in T>(T s);
        //public delegate void Info<T,U>(T s,U u);
        //public delegate void Info<T,U,Z>(T s,U u,Z z);
        //public delegate bool CustomPredicate<in T>(T obj);
        static void Main(string[] args)
        {
            #region Collection
            //ArrayList list = new ArrayList();
            //list.Add("Kamran");
            //list.Add(true);
            //list.Add(10);
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(-100);
            //list.Add(1000);
            //list.Sort();
            //Console.WriteLine(list.Contains(200));
            //list.Clear();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //LinkedList<int> list = new LinkedList<int>();
            //Dictionary<string, string> contacts = new Dictionary<string, string>();
            //contacts.Add("Kamran", "0512373434");
            //contacts.Add("Ibrahim", "0519918198");
            //contacts.Add("Fidan", "0707570708");
            //contacts.Add("Mehemmed", "0513134794");
            //foreach (var item in contacts)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            //Console.WriteLine(contacts["Kamran"]);
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Gulchin");
            //queue.Enqueue("Simare");
            //queue.Enqueue("Emil");
            //Console.WriteLine("Hazirda novbede:");
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine("Siradan chixan:");
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Siradakilar:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Gulchin");
            //stack.Push("Emilya");
            //stack.Push("Ibrahim");
            //stack.Pop();
            //stack.Pop();

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Delegate
            #region Action - void,17 overloading
            //Action<int> intInfo = PrintNumber;
            //Action<bool> boolInfo = Print;
            //Action<string> strInfo = GetUpper;
            #endregion

            #region Func - return type delegate,17
            //Func<string, int> test = Test;
            //Func<int, int, bool> func = (n1, n2) => n1 + n2 > 0;
            //Func<int, int, bool> func = delegate (int n1, int n2)
            //{
            //    return n1 + n2 > 0;
            //};
            #endregion

            #region Predicate - return bool,1 parametr
            //CustomPredicate<int> predicate = n =>
            //{
            //    n += 10;
            //    return n > 0;
            //};
            //Predicate<int> predicate = delegate (int n)
            //  {
            //      return n > 0;
            //  };
            #endregion

            //Console.WriteLine(Sum(new int[] { 1,2,-10,3,-7},GetNegative));
            //Console.WriteLine(Sum(new int[] { 1,2,-10,3,-7},GetPosiytive));
            //InfoStr info = GetUpper;
            //info += GetLower;
            //info += GetFirstChar;
            //info -= GetUpper;
            //info +=  str => Console.WriteLine(str[str.Length-1]);
            //info("Emilya");

            #endregion

            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(100);
            //list.Add(1000);
            //Console.WriteLine(list.Find(n => n == 1));

            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(100);
            myList.Add(1000);
            Console.WriteLine(myList.Find(n=>n==1));
        }

        #region Delegate

        //public static int Test(string str)
        //{
        //    return str.Length;
        //}
        //static void PrintNumber(int number)
        //{
        //    Console.WriteLine(number);
        //}

        //static void Print(bool x)
        //{
        //    Console.WriteLine(x);
        //}
        //static void GetUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}

        //static void GetLower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //static void GetFirstChar(string str)
        //{
        //    Console.WriteLine(str[0]);
        //}

        //static int Sum(int[] arr, Check func)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (func(item)) 
        //            result += item;
        //    }
        //    return result;
        //}

        //static bool GetPosiytive(int item)
        //{
        //    return item > 0;
        //}

        //static bool GetNegative(int item)
        //{
        //    return item < 0;
        //}

        
        #endregion
    }
}
