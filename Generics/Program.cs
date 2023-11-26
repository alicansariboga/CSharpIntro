using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); //4

            //MyList<string> sehirler2 = new MyList(); //not generic
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count); //7
        }
    }
    class MyList<T> //generic class
    {
        T[] _array;
        T[] _tempArray; // When I increase the length of the array, a new array is created and the information of the previous array is not included. Therefore, temp is created to transfer the information of the previous array.
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1]; //count update
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // The process of copying the newly created array from the array in memory.
            }
            _array[_array.Length - 1] = item; //The last item added to the array
        }

        //count prop
        public int Count
        {
            get { return _array.Length; } //readonly bc the count using int the list is just readonly.
        }

    }
}
