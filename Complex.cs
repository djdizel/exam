using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Complex
    {
        private double real;
        private double imaginary;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public Complex Add(Complex other)
        {
            double newReal = real + other.real;
            double newImaginary = imaginary + other.imaginary;
            return new Complex(newReal, newImaginary);
        }

        public Complex Subtract(Complex other)
        {
            double newReal = real - other.real;
            double newImaginary = imaginary - other.imaginary;
            return new Complex(newReal, newImaginary);
        }

        public Complex Multiply(Complex other)
        {
            double newReal = real * other.real - imaginary * other.imaginary;
            double newImaginary = real * other.imaginary + imaginary * other.real;
            return new Complex(newReal, newImaginary);
        }

        public override string ToString()
        {
            if (imaginary >= 0)
            {
                return real + " + " + imaginary + "i";
            }
            else
            {
                return real + " - " + Math.Abs(imaginary) + "i";
            }
        }
    }
}
