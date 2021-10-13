using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jakNet50_MathExt
{
    public static class Angles
    {
        /// <summary>
        /// Convert the radian value in to the equivalent degree value
        /// </summary>
        /// <param name="value">Angle to convert</param>
        /// <returns>Equivalent angle in degrees</returns>
        public static double RadDeg(double value)
        {
            return value * (180 / Math.PI);
        }

        /// <summary>
        /// Convert the degree value in to the equivalent radian value
        /// </summary>
        /// <param name="value">Angle to convert</param>
        /// <returns>Equivalent angle in radians</returns>
        public static double DegRad(double value)
        {
            return value / (180 / Math.PI);
        }

        /// <summary>
        /// Function to shrink the angle value between 0 and 2pi
        /// </summary>
        /// <param name="value">Angle to check</param>
        /// <returns></returns>
        public static double AngleFit2Pi(double value)
        {
            double tmpAngle = value;
            while(tmpAngle <= (Math.PI * 2) && tmpAngle >= 0)
            {
                if (tmpAngle > (Math.PI * 2)) { tmpAngle -= Math.PI * 2; }
                if (tmpAngle < 0d) { tmpAngle = (Math.PI * 2) + tmpAngle; }
            }
            return tmpAngle;
        }

        /// <summary>
        /// Function to shrink the angle value between -pi and +pi
        /// </summary>
        /// <param name="value">Angle to check</param>
        /// <returns></returns>
        public static double AngleFit1Pi(double value)
        {
            double tmpAngle = value;
            while (tmpAngle <= Math.PI && tmpAngle >= -Math.PI)
            {
                if (tmpAngle > Math.PI) { tmpAngle -= Math.PI * 2; }
                if (tmpAngle < -Math.PI) { tmpAngle = (Math.PI * 2) + tmpAngle; }
            }
            return tmpAngle;
        }

        /// <summary>
        /// Convert an angle from the mathematical to the coordinates convention
        /// </summary>
        /// <param name="value">Angle to convert</param>
        /// <returns>Converted angle</returns>
        public static double AngleToBearing(double value)
        {
            return AngleFit2Pi(((2 * Math.PI) - value) + (Math.PI / 2));
        }

        /// <summary>
        /// Convert an angle from the mathematical to the coordinates convention
        /// </summary>
        /// <param name="value">Angle to convert</param>
        /// <returns>Converted angle</returns>
        public static double BearingToAngle(double value)
        {
            return AngleFit2Pi((2 * Math.PI) - (value - (Math.PI / 2)));
        }

        /// <summary>
        /// Represent the secant of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Sec(double value)
        {
            return 1 / Math.Cos(value);
        }

        /// <summary>
        /// Represent the cosecant of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double CSec(double value)
        {
            return 1 / Math.Sin(value);
        }

        /// <summary>
        /// Represent the cotangent of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double CTan(double value)
        {
            return 1 / Math.Tan(value);
        }

        /// <summary>
        /// Retrive the angle from the sine value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ASin(double value)
        {
            return Math.Atan(value / Math.Sqrt((-value * value) + 1));
        }

        /// <summary>
        /// Retrive the angle from the cosine value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ACos(double value)
        {
            return Math.Atan(-value / Math.Sqrt(-value * value + 1)) + 2 * Math.Atan(1);
        }

        /// <summary>
        /// Retrive the angle from the secant value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ASec(double value)
        {
            return 2 * Math.Atan(1) - Math.Atan(Math.Sign(value) / Math.Sqrt(value * value - 1));
        }

        /// <summary>
        /// Retrive the angle from the cosecant value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ACSec(double value)
        {
            return Math.Atan(Math.Sign(value) / Math.Sqrt(value * value - 1));
        }

        /// <summary>
        /// Retrive the angle from the cotangent value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ACTan(double value)
        {
            return 2 * Math.Atan(1) - Math.Atan(value);
        }

        /// <summary>
        /// Represent the hyperbolic sine of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double SinH(double value)
        {
            return (Math.Exp(value) - Math.Exp(-value)) / 2;
        }

        /// <summary>
        /// Represent the hyperbolic cosine of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double CosH(double value)
        {
            return (Math.Exp(value) + Math.Exp(-value)) / 2;
        }

        /// <summary>
        /// Represent the hyperbolic tangent of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double TanH(double value)
        {
            return (Math.Exp(value) - Math.Exp(-value)) / (Math.Exp(value) + Math.Exp(-value));
        }

        /// <summary>
        /// Represent the hyperbolic secant of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double SecH(double value)
        {
            return 2 / (Math.Exp(value) + Math.Exp(-value));
        }

        /// <summary>
        /// Represent the hyperbolic cosecant of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double CSecH(double value)
        {
            return 2 / (Math.Exp(value) - Math.Exp(-value));
        }

        /// <summary>
        /// Represent the hyperbolic cotangent of an angle
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double CTanH(double value)
        {
            return (Math.Exp(value) + Math.Exp(-value)) / (Math.Exp(value) - Math.Exp(-value));
        }

        /// <summary>
        /// Retrive the angle from the hyperbolic sine value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ASinH(double value)
        {
            return Math.Log(value + Math.Sqrt(value * value + 1));
        }

        /// <summary>
        /// Retrive the angle from the hyperbolic cosine value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ACosH(double value)
        {
            return Math.Log(value + Math.Sqrt(value * value - 1));
        }

        /// <summary>
        /// Retrive the angle from the hyperbolic tangent value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ATanH(double value)
        {
            return Math.Log((1 + value) / (1 - value)) / 2;
        }

        /// <summary>
        /// Retrive the angle from the hyperbolic secant value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ASecH(double value)
        {
            return Math.Log((Math.Sqrt(-value * value + 1) + 1) / value);
        }

        /// <summary>
        /// Retrive the angle from the hyperbolic cosecant value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ACSecH(double value)
        {
            return Math.Log((Math.Sign(value) * Math.Sqrt(value * value + 1) + 1) / value);
        }

        /// <summary>
        /// Retrive the angle from the hyperbolic cotangent value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ACTanH(double value)
        {
            return Math.Log((value + 1) / (value - 1)) / 2;
        }

        /// <summary>
        /// Retrieve the hypotenuse from X and Y dimensions
        /// </summary>
        /// <param name="valueX">X dimension</param>
        /// <param name="valueY">Y dimension</param>
        /// <returns></returns>
        public static double Hypot(double valueX, double valueY)
        {
            double a = Math.Max(Math.Abs(valueX), Math.Abs(valueY));
            double b = Math.Min(Math.Abs(valueX), Math.Abs(valueY)) / (a==0 ? 1 : a);
            return a * Math.Sqrt(1 + b * b);
        }

    }
}
