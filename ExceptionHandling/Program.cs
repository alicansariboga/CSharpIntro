using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Bol(20, 0));
        }
    }
    class Matematik
    {
        public int Topla(int sayi1,  int sayi2)
        {
            return sayi1 + sayi2;
        }
        public decimal Bol(int sayi1, int sayi2)
        {
            try
            {
                //process
                return sayi1/ sayi2;
            }
            catch (DivideByZeroException)
            {
                //error
                Console.WriteLine("There is an error.");
                throw new DivideByZeroException("It can not be divided by zero."); //error
            }
            catch(DllNotFoundException) //exapmle error
            {
                // do it like anything.
                Console.WriteLine("There is an other error.");
                throw new DllNotFoundException();
            }
            catch (Exception exception)
            {
                // The error that is never encountered is stated as - exception
                Console.WriteLine("Catch worked. There is an error unknown. Apply the administrator.");
                Console.WriteLine(exception.InnerException);
                throw; //throw same error.
            }
            //optional
            finally 
            {
                // This block, everytime works.
                Console.WriteLine("Finally block worked.");
            }
        }
    }
}
