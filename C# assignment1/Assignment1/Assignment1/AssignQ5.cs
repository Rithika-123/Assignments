using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ5
    {
        public static void Main()
        {
            try
            {
                float PI = 3.141F;
                float R;
                Console.WriteLine("Enetr the Radius Value");
                R = int.Parse(Console.ReadLine());
                float circum = 2 * PI * R * R;
                float area = PI * R * R;
                Console.WriteLine("Circumfrence = {0} and Area = {1}", circum, area);
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.ToString());
            }
            finally
            {
                Console.WriteLine("The Value is Final");
            }
        }
    }
}

