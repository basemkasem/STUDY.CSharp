using System;

namespace STUDY.CSharp;

public class Point3D
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Z { get; private set; }

    public Point3D() : this(0, 0, 0)
    {
        
    }
    
    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
    }

    public static void Display(Point3D[] points)
    {
        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine($"Point {i+1} => X: {points[i].X}, Y: {points[i].Y}, Z: {points[i].Z}");
        }
    }
    public void ChangeCoordinates(double newX, double newY, double newZ)
    {
        X = newX;
        Y = newY;
        Z = newZ;
    }

    public static bool operator ==(Point3D p1, Point3D p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
    }

    public static bool operator !=(Point3D p1, Point3D p2)
    {
        return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z;

    }

    public override string ToString()
    {
        return $"{X}, {Y}, {Z}";
    }

    public override bool Equals(object obj)
    {
        if(ReferenceEquals(this, obj)) return true;
        if (obj is Point3D)
        {
            Point3D p = (Point3D)obj;
            return X == p.X && Y == p.Y && Z == p.Z;
        }
        
        return false;
    }
    
}