using System;
using System.Threading;
using System.Threading.Tasks;

namespace Asyncdemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread basladi. Thread : {Thread.CurrentThread.ManagedThreadId}");
            // More Threads ---
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            Process1Async();
            /*
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            Process2Async();
            */
            // -----------------
            Process1();
            Process2();
            Console.ReadKey();
        }
        static void Process1()
        {
            Console.WriteLine($"Sync Islem 1 basladi. Thread : {Thread.CurrentThread.ManagedThreadId}");
        }
        // void de olabilir fakat async oldugunda ndolayi Task donmesi daha dogru olur.
        static async Task Process1Async()
        {
            await Task.Run(() => {
            Thread.Sleep(1000); // delay
                Console.WriteLine($"Async Islem 1 basladi. Thread : {Thread.CurrentThread.ManagedThreadId}");
            });
        }
        static void Process2()
        {
            Console.WriteLine($"Sync Islem 2 basladi. Thread : {Thread.CurrentThread.ManagedThreadId}");
        }
        static async Task Process2Async()
        {
            await Task.Run(() => {
                Console.WriteLine($"Async Islem 2 basladi. Thread : {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}
