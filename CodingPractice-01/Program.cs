using System;
using System.Collections.Generic;
using System.Linq;


class codPrac
{
    static void Main()
    {
        //Prac_1();
        Prac_2();
    }

    static void Prac_1()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        IEnumerable<int> result = numbers.Where(n => n > 3);
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
    static void Prac_2()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        IEnumerable<string> result = names.Where(n => n.Contains("a"));
        foreach(string n in result)
        {
            Console.WriteLine(n);
        }
    }
    static void Prac_3()
    {

    }
    static void Prac_4()
    {

    }
    static void Prac_5()
    {

    }
    static void Prac_6()
    {

    }

}