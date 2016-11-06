/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: OXGame.cs                         
//DATE: 6 Nov 2016                           
/////////////////////////////////////////////
﻿
using System;
class test
{
    static void Main()
    {
        Console.Write("Starting with? (O or X) : ");
        char start = Convert.ToChar(Console.ReadLine());
        int ii = 0;
        char[,] table = new char[3, 3];
        while (true)
        {
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column: ");
            int column = int.Parse(Console.ReadLine());
            char now = start;
            if (ii % 2 == 0) now = start;
            else if (ii % 2 == 1 && start == 'X') now = 'O';
            else if (ii % 2 == 1 && start == 'O') now = 'X';
            table[row, column] = now;
            bool win = false;
            if (table[0, 0] == table[1, 0] && table[1, 0] == table[2, 0]) if (table[0, 0] == now) win = true;//h
            if (table[0, 1] == table[1, 1] && table[1, 1] == table[2, 1]) if (table[0, 1] == now) win = true;//h
            if (table[0, 2] == table[1, 2] && table[1, 2] == table[2, 2]) if (table[0, 2] == now) win = true;//h
            if (table[0, 0] == table[0, 1] && table[0, 1] == table[0, 2]) if (table[0, 0] == now) win = true;//w
            if (table[1, 0] == table[1, 1] && table[1, 1] == table[1, 2]) if (table[1, 0] == now) win = true;//w
            if (table[2, 0] == table[2, 1] && table[2, 1] == table[2, 2]) if (table[2, 0] == now) win = true;//w
            if (table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2]) if (table[0, 0] == now) win = true;//c
            if (table[2, 0] == table[1, 1] && table[1, 1] == table[0, 2]) if (table[2, 0] == now) win = true;//c
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(table[i, j]);
                Console.WriteLine();
            }
            if (win)
            {
                Console.WriteLine("===========\nWinner is {0}", now);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        Console.Write(table[i, j]);
                    Console.WriteLine();
                }
                break;
            }
            ii++;
        }
    }
}
