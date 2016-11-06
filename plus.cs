/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: plus.cs                           
//DATE: 5 Nov 2016                           
/////////////////////////////////////////////
﻿
using System;
class test
{
    static void Main()
    {
        Console.Write("Size: ");
        int size = int.Parse(Console.ReadLine());
        int[,] table = new int[size, size];
        if (size < 3)
        {
            Console.WriteLine("Too small.");
            return;
        }
        while (true)
        {
            string a = Console.ReadLine();
            if (a.ToUpper() == "END") break;
            string[] inp = a.Split(',');
            point(table, Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]));
        }
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (table[i, j] == 0) Console.Write('.');
                else Console.Write(table[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void point(int[,] table, int fn, int ln)
    {
        addpoint(table, fn, ln);
        addpoint(table, fn - 1, ln);
        addpoint(table, fn + 1, ln);
        addpoint(table, fn, ln - 1);
        addpoint(table, fn, ln + 1);
    }
    static void addpoint(int[,] table, int fn, int ln)
    {
        if (fn < 0 || ln < 0) return;
        table[fn, ln]++;
    }
}
