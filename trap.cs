/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: trap.cs                           
//DATE: 5 Nov 2016                           
/////////////////////////////////////////////
﻿
using System;
class test
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        string ans = "Found mine(s) at ";
        int w = 0, h = 0, line = 0 ;
        while(true)
        {
            char a = Convert.ToChar(Console.Read());
            if (a == '#') ans = ans + "["+Convert.ToString(h) + ","+Convert.ToString(w) + "] ";
            w++;
            if (a=='\n') { w = 0; h++; line++; }
            if (line == n) break;
        }
        Console.Write(ans);
    }
    
}
