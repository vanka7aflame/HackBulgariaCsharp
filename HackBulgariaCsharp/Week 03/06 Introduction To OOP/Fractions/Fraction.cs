using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        private double numerator;
        private double denominator;

        public  Fraction(double numerator, double denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public double Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public double Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        public override string ToString()
        {
            string asd = "";
            Console.WriteLine("{0}/{1}", numerator, denominator);
            return asd;
        }
        public override bool Equals(object obj)
        {
            if (this.numerator == (obj as Fraction).numerator && this.denominator == (obj as Fraction).denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Fraction obj, Fraction obj2)
        {
            if (obj.numerator == obj2.numerator && obj.denominator == obj2.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fraction obj, Fraction obj2)
        {
            if (obj.numerator != obj2.numerator && obj.denominator != obj2.denominator)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }

        public static double operator +(Fraction obj, Fraction obj2)
        {
            double lcm = obj.denominator * obj2.denominator;
            obj.numerator *= obj2.denominator;
            obj2.numerator *= obj.denominator;
            return (obj.numerator + obj2.numerator) / lcm;
        }
        public static double operator -(Fraction obj, Fraction obj2)
        {
            double lcm = obj.denominator * obj2.denominator;
            obj.numerator *= obj2.denominator;
            obj2.numerator *= obj.denominator;
            return (obj.numerator - obj2.numerator) / lcm;
        }
        public static double operator *(Fraction obj, Fraction obj2)
        {
            return (obj.numerator * obj2.numerator) / (obj.denominator * obj2.denominator);
        }
        public static double operator /(Fraction obj, Fraction obj2)
        {
            return (obj.numerator * obj2.denominator) / (obj2.numerator * obj.denominator);
        }

        public static double operator +(Fraction obj, double num)
        {
            return (obj.numerator / obj.denominator) + num;
        }
        public static double operator -(Fraction obj, double num)
        {
            return (obj.numerator / obj.denominator) - num;
        }
        public static double operator *(Fraction obj, double num)
        {
            return (obj.numerator / obj.denominator) * num;
        }
        public static double operator /(Fraction obj, double num)
        {
            return (obj.numerator / obj.denominator) / num;
        }
    }
}
