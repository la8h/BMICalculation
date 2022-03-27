using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmi = 0;
            Console.Write("Enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            double hight = double.Parse(Console.ReadLine());

            bmi = weight / (hight * hight);

            Console.WriteLine("Your BMI is: " + bmi);

            Console.WriteLine("................................................");
            Console.WriteLine("Classification\tBMI Category (kg/m^2)");
            Console.WriteLine("Underweight\t<18.5");
            Console.WriteLine("Noraml Weight\t18.5 - 24.9");
            Console.WriteLine("Overweight\t25.0 - 29.9");
            Console.WriteLine("Obese classI\t30.0 - 34.9");
            Console.WriteLine("Obese class II\t35.0 - 39.9");
            Console.WriteLine("Obese class III\t>= 40.0");


            Console.ReadLine();
        }
    }
}
