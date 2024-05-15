using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resistenza r1 = new Resistenza(220);
            Resistenza r2 = new Resistenza(220);
            Console.WriteLine(r1 & r2);
            Console.WriteLine(r2 & r1);

         

        }
    }
}
