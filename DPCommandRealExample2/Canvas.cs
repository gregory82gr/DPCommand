using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCommandRealExample2
{
    //Receiver - Graphics Editor Canvas
    public class Canvas
    {
        public void DrawCircle()
        {
            Console.WriteLine("Circle drawn");
        }
        public void RemoveCircle()
        {
            Console.WriteLine("Circle removed");
        }
        public void DrawRectangle()
        {
            Console.WriteLine("Rectangle drawn");
        }
        public void RemoveRectangle()
        {
            Console.WriteLine("Rectangle removed");
        }
    }
}
