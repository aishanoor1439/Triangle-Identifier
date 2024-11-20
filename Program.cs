using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: three angles of the triangle
            Console.WriteLine("Enter the first angle of the triangle: ");
            int angle1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second angle of the triangle: ");
            int angle2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third angle of the triangle: ");
            int angle3 = Convert.ToInt32(Console.ReadLine());

            // Check if the sum of the angles is 180
            int sumOfAngles = angle1 + angle2 + angle3;

            if (sumOfAngles == 180 && angle1 > 0 && angle2 > 0 && angle3 > 0)
            {
                Console.WriteLine("A triangle can be formed with these angles.");
            }
            else
            {
                Console.WriteLine("A triangle cannot be formed with these angles.");
            }
        }
    }
}
