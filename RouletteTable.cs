using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteV2
{
    public class RouletteTable
    {
        public static void DrawBoard() //Took this from Nathan's code just to make the program more aesthetically pleasing. 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    +-----+-----+-----+-----+-----+-----+    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\tTYPES OF BETS:");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    | 1-18| EVEN| RED |BLACK| ODD |19-36|    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t1. Numbers: Number of the bin");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("+---+--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t2. Evens/Odds: Number is even or odd");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 3");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 6");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 9");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("12");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("15");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("18");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("21");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("24");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("27");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("30");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("33");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("36");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|3rd|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t3. Reds/Blacks: Number is red or black");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 +--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t4. Lows/Highs: Number is 1-18 or 19-36");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|---|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 2");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 5");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 8");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("11");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("14");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("17");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("20");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("23");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("26");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("29");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("32");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("35");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|2nd|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t5. Dozens: Number is 1-12, 13-24, 25-36");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|   +--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t6. Colums: Number is in 1st, 2nd or 3rd");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("| 0 |");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 1");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" 4");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" 7");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("10");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("13");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("16");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("19");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("22");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("25");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("28");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("31");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("34");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("|1st|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t7. Street: Number is in the same row");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("+---+--+--+--+--+--+--+--+--+--+--+--+--+---+");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t8. Six Numbers: Number is on one of the adjacent rows");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    |    1-12   |   13-24   |   25-36   |    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t9. Split: Number is one of the adjacent numbers");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("    +-----------+-----------+-----------+    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t10. Corner: Number is one of the corner pieces");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}
