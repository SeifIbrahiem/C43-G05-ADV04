using C43_G05_ADV04.Fifa;
using System.Collections;

namespace C43_G05_ADV04
{
    internal class Program
    {
        static void Main()
        {
            #region example1
            //Ball ball = new Ball() { Id = 1 };
            //Console.WriteLine(ball);
            //ball.Location = new Location() { X = 0, Y = 0, Z = 0 };
            //Console.WriteLine(ball); 
            #endregion

            #region overview wih hashtable
            //collection : Built_in_datstructure in c#
            //key : must be unique / not allow null 
            //===================================================//
            //Non_generic hashtable : hashtable 
            //based on object with in (key , value ) with type object 
            //classhashtable : use double hashing 
            //عشان نقلل احتماليه تكرار index
            //there are hashsize<buckets>in the table
            //hashtable based on array of buckets
            //Hashtable hashtable = new Hashtable 
            #endregion

            #region ex1 with hashtable

            Hashtable PhoneBook=new Hashtable();
            PhoneBook.Add("seif", 1111);
            PhoneBook.Add("ali", 22222);
            PhoneBook.Add("alia", 333322);
            PhoneBook.Add("amer", 2888822);
            Console.WriteLine(PhoneBook.Count);
            Console.WriteLine(PhoneBook.IsFixedSize);
            Console.WriteLine(PhoneBook.IsReadOnly);
            foreach (DictionaryEntry item in PhoneBook) 
            {
                Console.WriteLine(item);
            }
            foreach (var item in PhoneBook.Values)
            {
                Console.WriteLine(item);
            }
            foreach (var item in PhoneBook.Keys)
            {
                Console.WriteLine(item);
            }
            //contain==containkey
            //Var x = 12 ;
            //Var x = 12.5 ;
            //Var x = "ali" ;
            #endregion

        }
    }
}
