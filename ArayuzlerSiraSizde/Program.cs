using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzlerSiraSizde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            kitap.Oku();
            Console.WriteLine("====================================");
            Dergi dergi = new Dergi();
            dergi.Oku();
            Console.WriteLine("====================================");
            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.Oku();
            Console.WriteLine("====================================");
        }
    }
    interface IOrtak
    {
        void Oku();
    }
    public class Kitap : IOrtak
    {
        public void Oku()
        {
            Console.WriteLine("kitap okundu.");
        }
    }
    public class Dergi : IOrtak
    {
        public void Oku()
        {
            Console.WriteLine("dergi okundu.");
        }
    }
    public class Ansiklopedi : IOrtak
    {
        public void Oku()
        {
            Console.WriteLine("ansiklopedi okundu.");
        }
    }
    
}
