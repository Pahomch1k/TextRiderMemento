using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Dz_16_TextRiderMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            string s = "Hi, I am Pasha";
            Originator originator = new Originator(s);
            Caretaker caretaker = new Caretaker(originator);
             
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Z)
                {
                    Console.WriteLine("\nCtrl + z\n");
                    caretaker.Undo();
                    Console.WriteLine();
                    caretaker.ShowHistory();
                }
                else
                {
                    s = Console.ReadLine();
                    caretaker.Backup();
                    originator.DoSomething(s);
                } 
            } 
        }
    }
}
