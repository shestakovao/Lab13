using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Пушкина, 13", 10 , 20 , 50);
            Console.WriteLine(building.Print());          
            MultiBuilding multiBuilding = new MultiBuilding("ул. Лермонтова, 21", 5, 10, 10, 4);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
