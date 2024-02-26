using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_6_2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
        public class Notes
        {
            public void Save(string notes)
            { 
                Console.WriteLine(notes); 
            }
        }
    }
}
