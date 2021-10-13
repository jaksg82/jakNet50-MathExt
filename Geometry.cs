using System;

namespace jakNet50_MathExt
{
    public static class Geometry
    {
        /// <summary>
        /// Calculate the heading of the line to join the two given point
        /// </summary>
        /// <param name="point1X">Start point X</param>
        /// <param name="point1Y">Start point Y</param>
        /// <param name="point2X">End point X</param>
        /// <param name="point2Y">End point Y</param>
        /// <returns>Heading value in radians</returns>
        public static double CalcHeading(double point1X, double point1Y, double point2X, double point2Y)
        {
            double deltaX = point2X - point1X;
            double deltaY = point2Y - point1Y;
            double hdg = Math.Atan2(deltaY, deltaX);
            if (hdg < 0) { hdg = (2 * Math.PI) + hdg; }
            return hdg;
        }

        /// <summary>
        /// Calculate the heading of the line to join the two given point
        /// </summary>
        /// <param name="point1">Start point</param>
        /// <param name="point2">End point</param>
        /// <returns>Heading value in radians</returns>
        public static double CalcHeading(Point3D point1, Point3D point2)
        {
            if (Point3D.IsValid2D(point1) && Point3D.IsValid2D(point2))
            {
                return CalcHeading(point1.X, point1.Y, point2.X, point2.Y);
            }
            else
            {
                return double.NaN;
            }
        }

        /// <summary>
        /// Calculate the coordinate of a point from the given point
        /// </summary>
        /// <param name="startPointX">Start point X</param>
        /// <param name="startPointY">Start point Y</param>
        /// <param name="range">Distance between start point and end point</param>
        /// <param name="bearing">Bearing in radians between start point and end point</param>
        /// <returns>Computed End point</returns>
        public static Point3D RangeBearing(double startPointX, double startPointY, double range, double bearing)
        {
            bearing = Angles.AngleFit2Pi(bearing);
            double arcb = Math.Abs(range * Math.Cos(bearing));
            double arsb = Math.Abs(range * Math.Sin(bearing));
            double rcb = range > 0 ? arcb : -arcb;
            double rsb = range > 0 ? arsb : -arsb;

            if (bearing == 0d || bearing == (2*Math.PI))
            { 
                return new Point3D(startPointX + range, startPointY);
            }
            if (bearing == (Math.PI /2))
            { 
                return new Point3D(startPointX, startPointY + range); 
            }
            if (bearing == Math.PI)
            { 
                return new Point3D(startPointX - range, startPointY);
            }
            if (bearing == (3 * Math.PI / 2))
            { 
                return new Point3D(startPointX, startPointY - range);
            }
            if (bearing < (Math.PI / 2) && bearing > 0d)
            {
                return new Point3D(startPointX + rcb, startPointY + rsb);
            }
            if (bearing > (3 * Math.PI / 2) && bearing < (2 * Math.PI))
            {
                return new Point3D(startPointX + rcb, startPointY - rsb);
            }
            if (bearing > (Math.PI / 2) && bearing < Math.PI)
            {
                return new Point3D(startPointX - rcb, startPointY + rsb);
            }
            if (bearing > Math.PI && bearing < (3 * Math.PI / 2))
            {
                return new Point3D(startPointX - rcb, startPointY - rsb);
            }
            return new Point3D(startPointX, startPointY);
        }

        /// <summary>
        /// Calculate the coordinate of a point from the given point
        /// </summary>
        /// <param name="startPoint">Start point</param>
        /// <param name="range">Distance between start point and end point</param>
        /// <param name="bearing">Bearing in radians between start point and end point</param>
        /// <returns>Computed End point</returns>
        public static Point3D RangeBearing(Point3D startPoint, double range, double bearing)
        {
            if (Point3D.IsValid2D(startPoint))
            {
                return RangeBearing(startPoint.X, startPoint.Y, range, bearing);
            }
            else
            {
                return new Point3D();
            }
        }

        /// <summary>
        /// Calculate the 2D distance between two points
        /// </summary>
        /// <param name="p1X">Start point X</param>
        /// <param name="p1Y">Start point Y</param>
        /// <param name="p2X">End point X</param>
        /// <param name="p2Y">End point Y</param>
        /// <returns>Computed distance</returns>
        public static double Distance2D(double p1X, double p1Y, double p2X, double p2Y)
        {
            double dX = p1X - p2X;
            double dY = p1Y - p2Y;
            return Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));
        }

        /// <summary>
        /// Calculate the 2D distance between two points
        /// </summary>
        /// <param name="p1">Start point</param>
        /// <param name="p2">End point</param>
        /// <returns>Computed distance</returns>
        public static double Distance2D(Point3D p1, Point3D p2)
        {
            if (Point3D.IsValid2D(p1) && Point3D.IsValid2D(p2))
            {
                return Distance2D(p1.X, p1.Y, p2.X, p2.Y);
            }
            else
            {
                return double.NaN;
            }
        }

        /// <summary>
        /// Calculate the 3D distance between two points
        /// </summary>
        /// <param name="p1X">Start point X</param>
        /// <param name="p1Y">Start point Y</param>
        /// <param name="p1Z">Start point Z</param>
        /// <param name="p2X">End point X</param>
        /// <param name="p2Y">End point Y</param>
        /// <param name="p2Z">End point Z</param>
        /// <returns>Computed distance</returns>
        public static double Distance3D(double p1X, double p1Y, double p1Z, double p2X, double p2Y,double p2Z)
        {
            double dX = p1X - p2X;
            double dY = p1Y - p2Y;
            double dZ = p1X - p2Z;
            return Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2) + Math.Pow(dZ, 2));
        }

        /// <summary>
        /// Calculate the 3D distance between two points
        /// </summary>
        /// <param name="p1">Start point</param>
        /// <param name="p2">End point</param>
        /// <returns>Computed distance</returns>
        public static double Distance3D(Point3D p1, Point3D p2)
        {
            if (Point3D.IsValid3D(p1) && Point3D.IsValid3D(p2))
            {
                return Distance3D(p1.X, p1.Y, p1.Z, p2.X, p2.Y,p1.Z);
            }
            else
            {
                return double.NaN;
            }
        }
    }
}
