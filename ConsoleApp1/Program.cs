using System;
using System.Threading;

namespace ConsoleApp1
    {
    class Program
        {
        static void Main (string[] args)
            {

            Thread thread1 = new Thread (new ThreadStart (Method1));
            Thread thread2 = new Thread (new ThreadStart (Method2));
            thread1.Start ();
            thread2.Start ();


            }

        private static void Method2 ()
            {
            for (int i = 0; ; i++)
                {
                if (i==500)
                    {
                        Thread.Sleep(3000);
                    }
                Console.WriteLine ("NewMethod : " + i);
                }
            }

        static void Method1 ()
            {
            for (int i = 0;  ; i++)
                {
                Console.WriteLine ("Method : "+i);
                }
            }
        }
    }
