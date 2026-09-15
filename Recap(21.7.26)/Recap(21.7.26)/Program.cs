using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// class class_name
class EncapData
{
    // field/feature/ variable of a class
    // access_specifier Data_type Variable_Name ;
    private float radius;
    private float pi = 3.141f;

    // defining a method
    public float getRadius()
    {
        return radius;
    }

    public void setRadius(float radius)
    {
        this.radius = radius;
    }

    // Getter for Area: Area = pi * r^2
    public double GetArea()
    {
        return pi * radius * radius;
    }

    // Getter for Circumference: Circumference = 2 * pi * r
    public double GetCircumference()
    {
        return 2 * pi * radius;
    }

}

class Program
{
    //Main Function
    public static void Main(string[] args)
    {
        //user input -> always taken in as strings
        Console.WriteLine("Enter Radius: ");
        float myradius = float.Parse(Console.ReadLine());
        // obj of a class
        EncapData encap = new EncapData();

        encap.setRadius(myradius);
        //encap.radius = myradius;
        Console.WriteLine("Radius " + encap.getRadius());
        Console.WriteLine("Area" + encap.GetArea());
        Console.WriteLine("Circumference" + encap.GetCircumference());
    }

}

