using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    //işte bu bunu MyDictionaryde Add fonksiyonu için hazırlarken Dictionary'i burada yapmışım zaten :D
    class MyList<Tkeylist,Tvaluelist>
    {
        
        (Tkeylist,Tvaluelist) [,] items;
        public MyList()
        {
            items = new (Tkeylist,Tvaluelist)[0,0];
        }
        public void Add(Tkeylist key, Tvaluelist value )
        {
            (Tkeylist, Tvaluelist)[,] tempArray = items;
            items = new (Tkeylist, Tvaluelist)[items.Length + 1,items.Length +1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i,i] = tempArray[i,i];    
            }
            items[items.Length - 1,items.Length -1] = (key,value);

        }

        public int Length 
        {
            get { return items.Length; }
            
        }

        public (Tkeylist, Tvaluelist)[,] Items
        {
            get { return items; }

        }
    }
}
