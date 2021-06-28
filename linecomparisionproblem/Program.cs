﻿using System;

namespace linecomparisionproblem
{
    class Program
    {
        const int EQUALITY = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to line comparison computation program");
            Random random = new Random();

            //assigning line points using randome Next() method 
            int[] x1 = new int[2];
            int[] y1 = new int[2];
            int[] x2 = new int[2];
            int[] y2 = new int[2];
            int cmpLine;

            for (int line = 0; line <= 1; line++)
            {
                x1[line] = random.Next(0, 10);
                y1[line] = random.Next(0, 10);
                x2[line] = random.Next(0, 10);
                y2[line] = random.Next(0, 10);
            }

            //calling static LineLength function
            double line1Length = Program.LineLength(x1[0], y1[0], x2[0], y2[0]);
            double line2Length = Program.LineLength(x1[1], y1[1], x2[1], y2[1]);
            Console.WriteLine("Welcome to Line Comparison Computation");
            cmpLine = line2Length.CompareTo(line1Length);

            //Comparing two lines 
            if (cmpLine > EQUALITY)
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            else if (cmpLine < EQUALITY)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("Two lines are Equal");
            }
            Console.Read();
        }


        //Calculating length of the line using LineLength method
        public static double LineLength(int xPt1, int yPt1, int xPt2, int yPt2)
        {
            double length = (Math.Sqrt((xPt2 - xPt1) ^ 2 + (yPt2 - yPt1) ^ 2));
            return length;

        }
    }
}
