using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo1
{
    public class Program
    {
        static void Main(string[] args) // Main Thread / UI Thread
        {
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");
            /*
            Process1();
            // delay second
            System.Threading.Thread.Sleep(5000);
            Process2 ();
            */

            // Method-1
            //Task task1 = new Task(Process1); //recognizing not run.
            //task1.Start();
            // Method-2
            //Task task1 = Task.Factory.StartNew(Process1);
            // Method-3
            // Task task = Task.Run(Process1);
            // Burada, sadece method cagirma zorunlulugu yoktur. Susulu parantez icerisine methodun kendisi de eklenerek calistirilabilir. Bunun yaninda, iki method ayni anda cagirilabilir. Yapinin kendisi asenkron bir sekilde calisir. Icindeki methodlar yine sirali bir sekilde calismaktadir.
            /*
            Task task = Task.Run(() => {
                Process1();
                Process2();
            });
            */
            // Task task = Task.Run(Process1AndProcess2); //same thing previous operation.

            Task task = Task.Run(Process1);

            task.Wait(); // task isleminin bitmesi beklenir ve sonra process2 islemi baslar ve task kesinlikle calisir.. Dolayisiyla output icin: start 1 ve ardindan start2 islemi gelir. Buradaki amac sadece sirayla calismak degil, yuku dagitma amaci da vardir.
            Process2();
            // Console.ReadKey(); // termination
            // Burada asenkron programlamada islemler cok hizli gerceklestirgi yeni thread acamadan uygulama sonlanabilir. Bundan kacinmak icin de gerekli koruma islemleri yapilmalidir ve sistemin saglikli bir sekilde calisabilmesi icin gerekli sure tanimlanmalidir.
        }
        static void Process1()
        {
            Console.WriteLine("Start 1. operation");
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Process2()
        {
            Console.WriteLine("Start 2. operation");
            Console.WriteLine($"Thread no : {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Process1AndProcess2()
        {
            Process1();
            Process2();
        }
    }
}