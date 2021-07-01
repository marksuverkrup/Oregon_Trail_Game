using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Wagon_Contents
    {
        public bool Sister { get; set; }
        public bool Brother { get; set; }
        public bool Ma { get; set; }
        public bool Pa { get; set; }
        public bool OxLarry { get; set; }
        public bool OxMartin { get; set; }
        public int Supplies { get; set; }
        public Wagon_Contents () { }
        public Wagon_Contents (bool sister, bool brother, bool ma, bool pa, bool oxLarry, bool oxMartin, int supplies)
        {
            Sister = sister;
            Brother = brother;
            Ma = ma;
            Pa = pa;
            OxLarry = oxLarry;
            OxMartin = oxMartin;
            Supplies = supplies;
        }
    }
}
