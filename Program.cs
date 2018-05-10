using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinputexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cylinder Calculator v0.1");
            Console.ReadKey();

            Console.Write("Enter height of cylinder : ");
            string heightinput = Console.ReadLine(); //height of a cylinder
            double heightvalue = Convert.ToInt32(heightinput); //converts input to height value for use in equation

            Console.Write("Enter radius of cylinder : ");
            string radiusinput = Console.ReadLine(); //radius of cylinder
            double radiusvalue = Convert.ToInt32(radiusinput); //converts input to radius value for use in equation

            //pi value
            double pi = 3.14;

            //Final equation for cylinder
            double volumecylinder = pi * radiusvalue * radiusvalue * heightvalue;
            Console.WriteLine("The volume of your cylinder is " + volumecylinder + " cubic units.");

            //Final equation for Area
            double areacylinder = 2 * pi * radiusvalue * (radiusvalue + heightvalue);
            Console.WriteLine("The surface area of your cylinder is " + areacylinder + " square units.");

            Console.ReadKey();
        }
    }
}
