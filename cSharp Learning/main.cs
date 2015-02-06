using System.IO;
using System;

class Program
{
    
    static void Main()
    {
        int feetValue = 50;
        Console.WriteLine(feetToInches(feetValue)/12 + " Feet = " + feetToInches(feetValue) + " inches.");
    }
    
    static int feetToInches(int feet){
        int inches = feet * 12;
        return inches;
    }
}
