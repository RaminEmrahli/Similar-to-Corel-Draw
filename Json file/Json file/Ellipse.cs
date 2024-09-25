using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Json_file
{
    internal class Ellipse
    {
        public float X { get;  set; }
        public float Y { get;   set; }
        public float Radius1 { get;   set; }
        public float Radius2 { get;  set; } 
      
        public Ellipse()
        {
            X = 0;
            Y = 0;
            Radius1 = 0;
            Radius2 = 0;
        }
    }
}
