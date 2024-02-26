using Essential_6_2;
using System;
using System.Collections.Generic;

namespace Essential6_2;

    class Program
    {
        static void Main()
        {
        Book.Notes notes = new Book.Notes();
        notes.Save("notes...");
            Console.ReadKey();
        }
    }