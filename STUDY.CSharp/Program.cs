using System;
using STUDY.CSharp;

Point3D p1 = new Point3D(1, 2, 3);
Point3D p2 = new Point3D(1, 2, 3);

Console.WriteLine(p1 == p2);

void ChangeStr(string str)
{
    str += " -> Added part to the string";
}
string str = "Hello World";
Console.WriteLine(str);
ChangeStr(str);
Console.WriteLine(str);