using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abtraction.abtractionClass;
using Abtraction.Interface;

namespace Abtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Abstract Class. ");
            Console.WriteLine();
            tumbuhan Tumbuhan;

            Tumbuhan = new xerofit();
            Tumbuhan.TempatHidup();

            Tumbuhan = new hidrofit();
            Tumbuhan.TempatHidup();

            Tumbuhan = new higrofit();
            Tumbuhan.TempatHidup();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Interface. ");
            Console.WriteLine();
            IReproduksi reproduksiTumbuhan;

            reproduksiTumbuhan = new generatif();
            reproduksiTumbuhan.berkembangBiak();

            reproduksiTumbuhan = new vegetatif();
            reproduksiTumbuhan.berkembangBiak();

            Console.ReadKey();
        }
    }
}