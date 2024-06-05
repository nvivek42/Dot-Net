using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class Circle: Shape
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle() {
            this.Center = new Point();
            this.Radius = 0;    
        }
        public Circle(Point center, int radius) {
            this.Center = center;
            this.Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("(" + this.Center + "), Radius=" + this.Radius + ")");
        }
    }
}
