using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четырехугольники
{
    class Romb : Figure
    {
        private double alfa;
        public Romb()
            : base("Ромб")
        {
            alfa = 42;
        }
        public Romb(double alfa, int width)
            : base("Ромб", width)
        {
            this.alfa = alfa;
        }
        private static double Radian(double alfa)
        {
            return alfa / 180 * Math.PI;
        }
        public override int H
        {
            get
            {
                return width * (int)Math.Sin(Radian(alfa));
            }
            set
            {
                throw new Exception("чзх");
            }
        }
        public override double Alfa
        {
            get
            {
                return alfa;
            }
            set
            {
                if (value > 0 & value < 180) alfa = value;
                else throw new Exception("чзх");
            }
        }
        public override double Diagonal()
        {
            return 2 * width * H / this.Diagonal();
        }
        public override double Perimetr()
        {
            return width * 4;
        }
        public override bool isQuare
        {
            get
            {
                return (alfa == 90);
            }
        }
        public override double Area()
        {
            return H * width;
        }
    }
}
