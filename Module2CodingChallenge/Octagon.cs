using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    class Octagon : Polygon
    {
        public float Size {  get; set; }
        public Octagon(float size) 
        {
            Size = size;
            NumberOfSides = 8;
        }
    }
}
