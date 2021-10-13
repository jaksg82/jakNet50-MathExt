using System;

namespace jakNet50_MathExt
{
    public class Point3D
    {
        #region Private variables
        private double dblX, dblY, dblZ;

        #endregion

        #region Public Properties

        public double X { get { return dblX; } set { dblX = value; } }
        public double Y { get { return dblY; } set { dblY = value; } }
        public double Z { get { return dblZ; } set { dblZ = value; } }

        #endregion

        #region Constructors

        public Point3D()
        {
            dblX = Double.NaN;
            dblY = Double.NaN;
            dblZ = Double.NaN;
        }

        public Point3D(double X, double Y)
        {
            dblX = X;
            dblY = Y;
            dblZ = Double.NaN;
        }

        public Point3D(double X, double Y, double Z)
        {
            dblX = X;
            dblY = Y;
            dblZ = Z;
        }

        #endregion

        #region Public Methods

        public static bool IsValid2D(Point3D point)
        {
            return Values.IsFinite(point.X) && Values.IsFinite(point.Y);
        }
        public static bool IsValid3D(Point3D point)
        {
            return Values.IsFinite(point.X) && Values.IsFinite(point.Y) && Values.IsFinite(point.Z);
        }


        #endregion 

        #region Overrides

        public static Point3D operator +(Point3D point1, Point3D point2)
        {
            Point3D point3 = new();
            if (point1 == null || point2 == null) {return null; }
            if (Values.IsFinite(point1.X))
            {
                if (Values.IsFinite(point2.X)) { point3.X = point1.X + point2.X; }
                else { point3.X = point1.X; }
            }
            else
            {
                if (Values.IsFinite(point2.X)) { point3.X = point2.X; }
            }

            if (Values.IsFinite(point1.Y))
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point1.Y + point2.Y; }
                else { point3.Y = point1.Y; }
            }
            else
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point2.Y; }
            }

            if (Values.IsFinite(point1.Z))
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point1.Z + point2.Z; }
                else { point3.Z = point1.Z; }
            }
            else
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point2.Z; }
            }

            return point3;
        }

        public static Point3D operator -(Point3D point1, Point3D point2)
        {
            Point3D point3 = new();
            if (point1 == null || point2 == null) { return null; }
            if (Values.IsFinite(point1.X))
            {
                if (Values.IsFinite(point2.X)) { point3.X = point1.X - point2.X; }
                else { point3.X = point1.X; }
            }
            else
            {
                if (Values.IsFinite(point2.X)) { point3.X = point2.X; }
            }

            if (Values.IsFinite(point1.Y))
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point1.Y - point2.Y; }
                else { point3.Y = point1.Y; }
            }
            else
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point2.Y; }
            }

            if (Values.IsFinite(point1.Z))
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point1.Z - point2.Z; }
                else { point3.Z = point1.Z; }
            }
            else
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point2.Z; }
            }

            return point3;
        }

        public static Point3D operator *(Point3D point1, Point3D point2)
        {
            Point3D point3 = new();
            if (point1 == null || point2 == null) { return null; }
            if (Values.IsFinite(point1.X))
            {
                if (Values.IsFinite(point2.X)) { point3.X = point1.X * point2.X; }
                else { point3.X = point1.X; }
            }
            else
            {
                if (Values.IsFinite(point2.X)) { point3.X = point2.X; }
            }

            if (Values.IsFinite(point1.Y))
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point1.Y * point2.Y; }
                else { point3.Y = point1.Y; }
            }
            else
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point2.Y; }
            }

            if (Values.IsFinite(point1.Z))
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point1.Z * point2.Z; }
                else { point3.Z = point1.Z; }
            }
            else
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point2.Z; }
            }

            return point3;
        }

        public static Point3D operator /(Point3D point1, Point3D point2)
        {
            Point3D point3 = new();
            if (point1 == null || point2 == null) { return null; }
            if (Values.IsFinite(point1.X))
            {
                if (Values.IsFinite(point2.X)) { point3.X = point1.X / point2.X; }
                else { point3.X = point1.X; }
            }
            else
            {
                if (Values.IsFinite(point2.X)) { point3.X = point2.X; }
            }

            if (Values.IsFinite(point1.Y))
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point1.Y / point2.Y; }
                else { point3.Y = point1.Y; }
            }
            else
            {
                if (Values.IsFinite(point2.Y)) { point3.Y = point2.Y; }
            }

            if (Values.IsFinite(point1.Z))
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point1.Z / point2.Z; }
                else { point3.Z = point1.Z; }
            }
            else
            {
                if (Values.IsFinite(point2.Z)) { point3.Z = point2.Z; }
            }

            return point3;
        }

        public static bool operator ==(Point3D point1, Point3D point2)
        {
            bool pX, pY, pZ;
            if (point1 == null || point2 == null) { return false; }
            else
            {
                pX = point1.X == point2.X;
                pY = point1.Y == point2.Y;
                pZ = point1.Z == point2.Z;
                return pX && pY && pZ;
            }
        }

        public static bool operator !=(Point3D point1, Point3D point2)
        {
            if (point1 == null || point2 == null) { return false; }
            else { return !(point1 == point2); }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

    }
}
