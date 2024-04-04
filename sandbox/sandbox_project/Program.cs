using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6, 7 };

        HashSet<int> unionSet = Union(set1, set2);
        HashSet<int> intersectSet = Intersection(set1, set2);

        Console.WriteLine("Union of set1 and set2:");
        foreach (var item in unionSet)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Intersection of set1 and set2:");
        foreach (var item in intersectSet)
        {
            Console.WriteLine(item);
        }
    }

    public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);
        foreach (var item in set2)
        {
            union.Add(item);
        }
        return union;
    }

        public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> list = new HashSet<int>(set1);
        HashSet<int> intersection = new HashSet<int>();

        foreach (var item in set2)
        {
            if (list.Contains(item))
            {
                intersection.Add(item);
            }
        }
        return intersection;
    }

    // Exemple 2
    //    public static void Main()
    //{
    //    HashSet<string> set1 = new HashSet<string> { "apple", "banana", "cherry" };
    //    HashSet<string> set2 = new HashSet<string> { "cherry", "pear", "orange" };

    //    HashSet<string> unionSet = Union(set1, set2);

    //    Console.WriteLine("Union of set1 and set2:");
    //    foreach (var item in unionSet)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

    //public static HashSet<string> Union(HashSet<string> set1, HashSet<string> set2)
    //{
    //    HashSet<string> union = new HashSet<string>(set1);
    //    foreach (var item in set2)
    //    {
    //        union.Add(item);
    //    }
    //    return union;
    //}

    //Exemple 3

    //    public static void Main()
    //{
    //    HashSet<object> set1 = new HashSet<object> { 1, 2, "apple", "banana" };
    //    HashSet<object> set2 = new HashSet<object> { "banana", "cherry", 3, 4 };

    //    HashSet<object> unionSet = Union(set1, set2);

    //    Console.WriteLine("Union of set1 and set2:");
    //    foreach (var item in unionSet)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

    //public static HashSet<object> Union(HashSet<object> set1, HashSet<object> set2)
    //{
    //    HashSet<object> union = new HashSet<object>(set2);

    //    foreach (var item in set1)
    //    {
    //        union.Add(item);
    //    }

    //    return union;
    //}
}
