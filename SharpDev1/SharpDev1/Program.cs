using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancja obiektu - nowy obiekt klasy rectangle
            Rectangle rectagnle = new Rectangle(16,20);
            int tempVal = rectagnle.GetHeight();

            rectagnle.Height = 123;
            var rect2 = rectagnle;
            rect2.Height = 444;
            Console.WriteLine(Rectangle.Height);

            Console.WriteLine(Rectangle.Height);
            var x1 = 100;
            var x2 = 200;
            var area = Rectangle.GetProvideArea(x1, x2);
            Console.WriteLine
        }
    }

    public class Rectangle
    {
        private int _height;
        private int width;

        public int Height;
        {
            get { return _height; }
            set { _height = value; }

        }
        public Rectangle(int width, int height)
{

}

        public int GetHeight()
        {
            return _height;
        }
     
      public static int GetProvideArea(int width, int height)
      {
    width = 10;
    //zapisac sie na korki (y)s
    height = 10;
    return width * height;
      }
        public static int GetProvideArea(ref int width, ref int height)
{

}
    
}
