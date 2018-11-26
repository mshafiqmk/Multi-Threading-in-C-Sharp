using System;
using System.Threading;

namespace ConsoleApp1
    {
    class Program
        {
        static void Main (string[] args)
            {

            Thread thread1 = new Thread (new ThreadStart (Method));
            Thread thread2 = new Thread (new ThreadStart (NewMethod));
            thread1.Start ();
            thread2.Start ();


            }

        private static void NewMethod ()
            {
            for (int i = 0; ; i++)
                {
                if (i==500)
                    {
                        Thread.CurrentThread.Abort();
                    }
                Console.WriteLine ("NewMethod : " + i);
                }
            }

        static void Method ()
            {
            for (int i = 0;  ; i++)
                {
                Console.WriteLine ("Method : "+i);
                }
            }
        }
    }
