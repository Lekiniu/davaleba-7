using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Lab
{
    static void Main(string[] args)
    {
        int i, j, vert, horiz;
        int[,] myArray = new int[50, 50];

        Console.WriteLine("vertikaluri rigi");
        vert = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("horizontaluri rigi");
        horiz = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sheitanet elementebi");
        for (i = 1; i <= vert; i++)
        {
            for (j = 1; j <= horiz; j++)
            {
                myArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("matrica : ");
        for (i = 1; i <= vert; i++)
        {
            for (j = 1; j <= horiz; j++)
            {
                Console.Write(" " + "{0}", myArray[i, j]);
            }
            Console.WriteLine();
        }

        int jami1 = 0;
        int jami2 = 0;
        if (vert == horiz)
        {
            for (i = 1; i <= vert; i++)
            {

                for (j = 1; j <= horiz; j++)
                {
                    if (i == j)
                    {
                        jami1 = jami1 + myArray[i, j];
                    }

                }

                jami2 = jami2 + myArray[i, horiz - i + 1];
            }
            int sxvaoba = jami1 - jami2;

            Console.WriteLine("jami= {0}", jami1);
            Console.WriteLine("meore jami= {0}", jami2);
            Console.WriteLine("sxvaoba= {0}", sxvaoba);
        }
        else
        {
            Console.WriteLine("moqmedeba sheusrulebelia");
        }


    }
}