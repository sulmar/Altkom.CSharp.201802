using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.HelloWorld
{
    public class Sender
    {
        public TItem Send<TItem>(TItem item)
        {
            Console.WriteLine($"sending {item}...");

            Console.WriteLine($"calculating...");

            return item;
        }

       
    }
}
