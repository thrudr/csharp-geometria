using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    public class rectangle
    {
        // FEATURES

        public int baseRectangle;
        public int heightRectangle;

        // METHODS

        public int areaCalculation()
        {
            int areaRectangle = baseRectangle * heightRectangle;
            return areaRectangle;
        }

        public int perimeterCalculation()
        {
            int perimeterRectangle = (baseRectangle + heightRectangle) * 2;
            return perimeterRectangle;
        }

        public void printRectangle()
        {
            Console.WriteLine("BASE: \t \t" + baseRectangle + " cm");
            Console.WriteLine("HEIGHT: \t" + heightRectangle + " cm");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("AREA: \t \t" + areaCalculation() + " cm2");
            Console.WriteLine("PERIMETER: \t" + perimeterCalculation() + " cm");
        }
    }
}
