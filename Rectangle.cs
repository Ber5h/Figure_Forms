using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четырехугольники
{
    class Rectangle : Figure
    {
        private int h;
        public Rectangle()
            : base("Прямоугольник")
        {
            h = 4;
        }
        public Rectangle (int width)
            :base ("Прямоугольник", width)
        {
            h = 4;
        }
        public Rectangle(int h, int width)
            : base("Прямуогольник", width)
        {
            this.h = h;
        }
        public override double Alfa
        {
            get
            {
                return 90;
            }
            set
            {
                throw new Exception("чзх");
            }
        }
        public override int H
        {
            get
            {
                return h;
            }
            set
            {
                if (value > 0) h = value;
                else throw new Exception("чзх");
            }
        }
        public override double Diagonal()
        {
            return Math.Sqrt(width * width + h * h);
        }
        public override double Perimetr()
        {
            return (width + h) * 2;
        }
        public override bool isQuare
        {
            get
            {
                return (width == h);
            }
        }
        public override double Area()
        {
            return h * width;
        }
    }
}
