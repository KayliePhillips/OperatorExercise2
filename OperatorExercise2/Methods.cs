using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise2
{
    internal class Methods
    {
        public static void AreaOfCircle() 
        {

            Console.WriteLine("Please input the radius of your circle.");
            var radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
        public static void LineSpacing()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
        


    }
    
}
