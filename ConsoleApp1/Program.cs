using System;
using System.Collections.ObjectModel;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        var list = new List<List<double[]>>() { new() {  } };
        var list1 = new List<List<double[]>>() { new() {  } };

        if (list.SequenceEqual(list1, new DoubleArrayComparer()))
        {
            Console.WriteLine(true);
            return;
        }

        Console.WriteLine(false);
    }

    public class DoubleArrayComparer : IEqualityComparer<List<double[]>>
    {
        public bool Equals(List<double[]> x, List<double[]> y)
        {
            return x.SequenceEqual(y, new DoubleSequenceComparer());
        }

        public int GetHashCode(List<double[]> obj)
        {
            return obj.GetHashCode();
        }
    }

    public class DoubleSequenceComparer : IEqualityComparer<double[]>
    {
        public bool Equals(double[]? x, double[]? y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(double[] obj)
        {
            return obj.GetHashCode();
        }
    }
}