using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlomsterSortTusindFryd
{
   public class BlomsterSort
    {

        public string Name { get; set; }
        public string Billedesti { get; set; }
        public int ProduktionsTid { get; set; }
        public int HalveringsTid { get; set; }
        public int Størrelse { get; set; }

        public BlomsterSort(string name, string billedesti, int produktionsTid, int halveringsTid, int størrelse)

        {
            Name =  name;
            Billedesti = billedesti;
            ProduktionsTid = produktionsTid;
            HalveringsTid = halveringsTid;
            Størrelse = størrelse;

        }

    }

   
}
