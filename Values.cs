using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jakNet50_MathExt
{
    public static class Values
    {
        /// <summary>
        /// Check if the value are a finite number
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Return true if is finite</returns>
        public static bool IsFinite(double value)
        {
            if(double.IsInfinity(value) || double.IsNaN(value)) { return false; }
            else if(double.MinValue < value && double.MaxValue > value) { return true; }
            else { return false; }
        }

        /// <summary>
        /// Calculate the Nth root of a number
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="root">Root degree</param>
        /// <returns>Computed rooted value</returns>
        public static double NthRoot(double value, double root)
        {
            return Math.Pow(value, (1 / root));
        }


        public static bool MultipleOf(double value, double root)
        {
            return (value % root == 0.0d);
        }
        public static bool MultipleOf(float value, float root)
        {
            return (value % root == 0.0f);
        }
        public static bool MultipleOf(int value, int root)
        {
            return (value % root == 0);
        }

        public static bool IsEven(int value)
        {
            return (value % 2 == 0);
        }

        public static double Average(double[] data)
        {
            double avg = 0.0d;
            if (data == null) { return double.NaN; }
            for (int i =0; i < data.Length; i++)
            {
                avg += data[i];
            }
            return avg /= data.Length;
        }

        public static double Average(List<double> data)
        {
            double avg = 0.0d;
            if (data == null) { return double.NaN; }
            for (int i = 0; i < data.Count; i++)
            {
                avg += data[i];
            }
            return avg /= data.Count;
        }

    }
}
