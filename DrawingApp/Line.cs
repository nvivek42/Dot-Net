using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class Line : Shape,IPrintable
    {   
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Line() {
            this.StartPoint = new Point();  
            this.EndPoint = new Point();    
        }
        public Line(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }
        public override void Draw()
        {
            Type t = this.GetType();
            Console.WriteLine("Type =" + t.Name);
            Console.WriteLine("in Line class's draw()");
            Console.WriteLine("(" + this.StartPoint + ", " + this.EndPoint + " )");
        }

        public void Print()
        {
            Console.WriteLine("Printing object using  exiting printer");

        }
    }
}
