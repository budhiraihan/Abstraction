using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Abtraction.Interface
{
    public class vegetatif : IReproduksi
    {
        public void berkembangBiak()
        {
            Console.WriteLine("vegetatif adalah cara perkembangbiakan tumbuhan tanpa pertemuan sel jantan dan betina");
        }
    }
}