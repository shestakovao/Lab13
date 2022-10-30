using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding : Building
    {
        int countFloor;

        public int CountFloor
        {
            get
            {
                return countFloor;
            }
            set
            {
                if (value == 0)
                {
                    countFloor = 1;
                }
                else
                {
                    countFloor = Math.Abs(value);
                }

            }
        }

        public MultiBuilding(string adres, double length, double width, double height, int countFloor)
            : base(adres, length, width, height)
        {
            this.CountFloor = countFloor;
        }

        public string Print()
        {
             return base.Print()+$"\n\tэтажность здания равна {countFloor}";
        }  

}
}
