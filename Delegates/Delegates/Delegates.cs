using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Delegates
{
    internal class Delegates
    {
        public delegate void ColorDelegate(Color color);
        ColorDelegate colorDelegate =null;
        public Delegates(ColorDelegate del)
        {
            colorDelegate = del;
        }
        public void AddDelegate(ColorDelegate del)
        {
            colorDelegate += del;
        }
        public void DeleteDelegate(ColorDelegate del)
        {
            colorDelegate -= del;
        }
        public void RunDelegate(Color color)
        {
            colorDelegate(color);
        }
    }
}
