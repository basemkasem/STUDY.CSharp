using System;
using STUDY.CSharp;

// Point3D p1 = new Point3D(1, 2, 3);
// Point3D p2 = new Point3D(2, 3, 3);
// Point3D p3 = new Point3D(2, 3, 0);
// Point3D p4 = (Point3D)p1.Clone();
// p1.Display();
// p1.X = 10;
// p4.Display();
// p1.Display();
// Point3D[] points = { p1, p2, p3 };
// Array.Sort(points);
//
// Point3D.Print(points);

// Trainee t1 = new Trainee("12345678", 5, 1000);
// Trainee t2 = new Trainee("12345678", 5, 1000);
//
// Console.WriteLine(t1.Compare(t1, t2));

PhoneBook phoneBook = new PhoneBook();
phoneBook[123] = "Ali";
Console.WriteLine(phoneBook[123]);
phoneBook["Hosam"] = 456;
Console.WriteLine(phoneBook[456]);
int phone = phoneBook["Ali"];
Console.WriteLine($"phone: {phone}");
Console.WriteLine();
phoneBook.Display();
