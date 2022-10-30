using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string adres;
        double length;
        double width;
        double height;

        public string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;  
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value == 0)
                {
                    length = 1;
                }
                else
                {
                    length = Math.Abs(value);
                }

            }
        }


        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value == 0)
                {
                    width = 1;
                }
                else
                {
                    width = Math.Abs(value);
                }

            }
        }


        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value == 0)
                {
                    height = 1;
                }
                else
                {
                    height = Math.Abs(value);
                }

            }
        }

        public Building(string adres, double length, double width, double height)
        { 
            this.Adres = adres;
            this.Length = length;
            this.Width = width; 
            this.Height = height;             
        }

        public string Print()
        {
            return $"Здание по адресу:{adres} имеет\n\tдлину равную {length} м\n\tширину равную {width} м\n\tвысоту равную {width} м";
        }


    }
}
