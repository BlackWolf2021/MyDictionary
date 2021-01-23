using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            //:D kodlar MyDictionaryde değil MyListte :D
            MyList<string, int> myList = new MyList<string, int>();
            myList.Add("yusuf", 20);
            foreach ( var item in myList.Items)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
