using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Alktom.CSharp.RentSystem.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Witaj w wypożyczalni");

            Write("Podaj imię: ");
            string firstName = ReadLine();

            Write("Podaj nazwisko: ");
            string lastName = ReadLine();

            var rentee = new Man();



        }
    }
}
