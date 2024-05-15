using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _24._28
{
    internal class Resistenza
    {
        public double Valore { get; set; }

        public Resistenza() { }
        public Resistenza(double valore)
        {
            Valore = valore;            
        }

        public static Resistenza operator &(Resistenza r1, Resistenza r2)
        {
            return new Resistenza(r1.Valore + r2.Valore);
        }
        public static Resistenza operator |(Resistenza r1, Resistenza r2)
        {
            return new Resistenza(1/((1/r1.Valore) + (1/r2.Valore)));
        } 
        public static bool operator ==(Resistenza r1, Resistenza r2)  //confronto di uguaglianza 
        {
            if (object.ReferenceEquals(r1, null))
                return object.ReferenceEquals(r2, null);
            else if (object.ReferenceEquals(r2, null))
                return false;
            else 
                return r2.Valore == r1.Valore;
        }
        public static bool operator !=(Resistenza r1, Resistenza r2)
        {
            return !(r1.Valore == r2.Valore);
        }

        public static bool operator >(Resistenza r1, Resistenza r2)
        {
            return r1.Valore > r2.Valore;
        }
        public static bool operator <(Resistenza r1, Resistenza r2) 
        {
            return r1.Valore < r2.Valore;
        }
        public override string ToString()
        {
            return String.Format($"{0}", Valore);
        }
        public static Resistenza Parse(string str)
        {
            string[] parts = str.Split();

            return new Resistenza(double.Parse(parts[0]));

        }



    }
}
