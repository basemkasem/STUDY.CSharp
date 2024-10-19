using System;
using STUDY.CSharp;

Point3D p1 = new Point3D(1, 2, 3);
Point3D p2 = new Point3D(2, 3, 3);
Point3D p3 = new Point3D(2, 3, 0);

Point3D p4 = (Point3D)p1.Clone();
p1.Display();
p1.X = 10;
p4.Display();
p1.Display();
// Point3D[] points = { p1, p2, p3 };
// Array.Sort(points);
//
// Point3D.Print(points);