using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program

    {
        public static void OnInicialization(object a, EventArgs b)
        {
            Handler1.Write();
            Handler2.Write();
        }
        public delegate void EvetHandler();

        static void Main(string[] args)
        {

            Counter counter = new Counter();
            counter.Inicialization += OnInicialization;
            counter.Inicializat();

        }

    }
}
