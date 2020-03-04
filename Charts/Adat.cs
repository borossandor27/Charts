using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts
{
    class Adat
    {
        float x;
        float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Adat(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
