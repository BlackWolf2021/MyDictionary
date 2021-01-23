using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {

        //iki listeyi tek liste haline getirmeye çalıştım ama olmanı sanırım tip güvenliğinden dolayı :D 
        //ayrıca burada isteyenler List yerine kendi MyListlerini de yazıp kullanabilirler :)
        //arka planda liste yerinde direk dictionaryde kullanabilirdim ama bu hile olurdu :D 
        //ya da dur yan projeden kendi My listimi alacam kapı gibi benim kendi listem var c# listesine mi kaldım
        //dostlarımmm listeyi bunun için modifiye ediyim derken dictionaryi yazmışım bile buna gerek kalmadı ama 
        //dursun yine anı olarak :D

        List<Tkey> tkeys = new List<Tkey>();
        List<Tvalue> tvalues = new List<Tvalue>();
        public void Add(Tkey tkey,Tvalue tvalue)
        {
            
        }
    }
}
