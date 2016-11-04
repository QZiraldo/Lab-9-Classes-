using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle
    {
        private double Radius;




        public Circle(double rad)
        {

            Radius = rad;
        }

        public double getCircumference()
        {
            double pi = Math.PI;
            double Circumference = 0;
            Circumference = (2 * pi * Radius);
            return Circumference;

        }

        public double getArea()
        {
            double pi = Math.PI;
            double area = 0;
            area = (Math.Pow((pi * Radius),2));
            return area;

        }

        private String formatNumber(double X)
        {
           double str = Math.Round(X, 2);
            string formatX = str.ToString();
            return formatX;
        }

        public String getFormattedCircumference()
        {
           return formatNumber(getCircumference());
        }

        public String getFormattedArea()
        {
           return formatNumber(getArea());
        }

    }
}
