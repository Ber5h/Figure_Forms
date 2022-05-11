using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четырехугольники
{
    abstract class Figure
    {
        protected string name; //бесполезнооооооооооооо
        protected int width;
        public Figure()
        {
            name = "Параллелограм";
            width = 4;
        }
        public Figure(string name)
        {
            this.name = name;
            width = 4;
        }
        public Figure(string name, int width)
        {
            this.name = name;
            this.width = width;
        }
        protected string Name
        {
            //в чем смысл этого поля
            get
            {
                return name;
            }
            set
            {
                if (value == "Прямоугольник" | value == "Ромб") name = value;
                else throw new Exception("чзх");
            }
        }
        protected int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0) width = value;
                else throw new Exception("чзх");
            }
        }
        abstract public double Alfa
        {
            get; set;
        }
        abstract public int H
        {
            get; set;
        }
        abstract public bool isQuare
        {
            get;
        }
        abstract public double Area();
        abstract public double Perimetr();
        abstract public double Diagonal();
    }
}
