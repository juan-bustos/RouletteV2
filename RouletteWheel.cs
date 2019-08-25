using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteV2
{
    //This is my original implementation of the roulette wheel.I really messed up by having them both as strings.It made a lot of my bets really hard to calculate.
    public class RouletteWheel
    {
        static Random Spin = new Random();
        public static string WheelSpin;
        public static string[] binNumber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "00"};
        public static int[] binDozens = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0};
        public static int[] binColumns = { 0, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 0 };

        public static string[] binColor = { "Green", "Red", "Black" , "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black" , "Red", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Green" };
        public static string SpinRouletteWheel()
        {
            WheelSpin = binNumber[Spin.Next(binNumber.Length)];
            Console.WriteLine($"The wheel stopped on: [{WheelSpin}]: {binColor[int.Parse(WheelSpin)]}");
            return WheelSpin;
        }
    }
}

    //public enum Colors { Red, Black, Green }
    //public class Bin    //values for each number choice, to make handling "easier"
    //{
    //public int Number { get; set; }
    //    public int Color { get; set; }
    //    public int Row { get; set; }
    //    public int Column { get; set; }
    //}
    //public class RouletteWheel  //This is Nathans implementation of the wheel. I'm using it because mine isn't working as well as I had hoped for some of my bets. 
    //{
    //    Bin[] binArr;
    //    public static SpinRouletteWheel()
    //    {
    //        binArr = new Bin[38];
    //        for (int i = 0; i < 38; i++)
    //        {
    //            binArr[i] = new Bin();
    //        }

    //        binArr[0].Number = 0;                   binArr[37].Number = 00;
    //        binArr[0].Color = (int)Colors.Green;    binArr[37].Color = (int)Colors.Green;
    //        binArr[0].Row = 0;                      binArr[37].Row = 0;
    //        binArr[0].Column = 0;                   binArr[37].Column = 0;

    //        binArr[1].Number = 1;                   binArr[2].Number = 2;                   binArr[3].Number = 3;
    //        binArr[1].Color = (int)Colors.Red;      binArr[2].Color = (int)Colors.Black;    binArr[3].Color = (int)Colors.Red;
    //        binArr[1].Row = 1;                      binArr[2].Row = 1;                      binArr[3].Row = 1;
    //        binArr[1].Column = 1;                   binArr[2].Column = 2;                   binArr[3].Column = 2;

    //        binArr[4].Number = 4;                   binArr[5].Number = 5;                   binArr[6].Number = 6;
    //        binArr[4].Color = (int)Colors.Black;    binArr[5].Color = (int)Colors.Red;      binArr[6].Color = (int)Colors.Black;
    //        binArr[4].Row = 2;                      binArr[5].Row = 2;                      binArr[6].Row = 2;
    //        binArr[4].Column = 1;                   binArr[5].Column = 2;                   binArr[6].Column = 3;

    //        binArr[7].Number = 7;                   binArr[8].Number = 8;                   binArr[9].Number = 9;
    //        binArr[7].Color = (int)Colors.Red;      binArr[8].Color = (int)Colors.Black;    binArr[9].Color = (int)Colors.Red;
    //        binArr[7].Row = 3;                      binArr[8].Row = 3;                      binArr[9].Row = 3;
    //        binArr[7].Column = 1;                   binArr[8].Column = 2;                   binArr[9].Column = 3;

    //        binArr[10].Number = 10;                 binArr[11].Number = 11;                 binArr[12].Number = 12;
    //        binArr[10].Color = (int)Colors.Black;   binArr[11].Color = (int)Colors.Black;   binArr[12].Color = (int)Colors.Red;
    //        binArr[10].Row = 4;                     binArr[11].Row = 4;                     binArr[12].Row = 4;
    //        binArr[10].Column = 1;                  binArr[11].Column = 2;                  binArr[12].Column = 3;

    //        binArr[13].Number = 13;                 binArr[14].Number = 14;                 binArr[15].Number = 15;
    //        binArr[13].Color = (int)Colors.Black;   binArr[14].Color = (int)Colors.Red;     binArr[15].Color = (int)Colors.Black;
    //        binArr[13].Row = 5;                     binArr[14].Row = 5;                     binArr[15].Row = 5;
    //        binArr[13].Column = 1;                  binArr[14].Column = 2;                  binArr[15].Column = 3;

    //        binArr[16].Number = 16;                 binArr[17].Number = 17;                 binArr[18].Number = 18;
    //        binArr[16].Color = (int)Colors.Red;     binArr[17].Color = (int)Colors.Black;   binArr[18].Color = (int)Colors.Red;
    //        binArr[16].Row = 6;                     binArr[17].Row = 6;                     binArr[18].Row = 6;
    //        binArr[16].Column = 1;                  binArr[17].Column = 2;                  binArr[18].Column = 3;

    //        binArr[19].Number = 19;                 binArr[20].Number = 20;                 binArr[21].Number = 21;
    //        binArr[19].Color = (int)Colors.Red;     binArr[20].Color = (int)Colors.Black;   binArr[21].Color = (int)Colors.Red;
    //        binArr[19].Row = 7;                     binArr[20].Row = 7;                     binArr[21].Row = 7;
    //        binArr[19].Column = 1;                  binArr[20].Column = 2;                  binArr[21].Column = 3;

    //        binArr[22].Number = 22;                 binArr[23].Number = 23;                 binArr[24].Number = 24;
    //        binArr[22].Color = (int)Colors.Black;   binArr[23].Color = (int)Colors.Red;     binArr[24].Color = (int)Colors.Black;
    //        binArr[22].Row = 8;                     binArr[23].Row = 8;                     binArr[24].Row = 8;
    //        binArr[22].Column = 1;                  binArr[23].Column = 2;                  binArr[24].Column = 3;

    //        binArr[25].Number = 25;                 binArr[26].Number = 26;                 binArr[27].Number = 27;
    //        binArr[25].Color = (int)Colors.Red;     binArr[26].Color = (int)Colors.Black;   binArr[27].Color = (int)Colors.Red;
    //        binArr[25].Row = 9;                     binArr[26].Row = 9;                     binArr[27].Row = 9;
    //        binArr[25].Column = 1;                  binArr[26].Column = 2;                  binArr[27].Column = 3;

    //        binArr[28].Number = 28;                 binArr[29].Number = 29;                 binArr[30].Number = 30;
    //        binArr[28].Color = (int)Colors.Black;   binArr[29].Color = (int)Colors.Black;   binArr[30].Color = (int)Colors.Red;
    //        binArr[28].Row = 10;                    binArr[29].Row = 10;                    binArr[30].Row = 10;
    //        binArr[28].Column = 1;                  binArr[29].Column = 2;                  binArr[30].Column = 3;

    //        binArr[31].Number = 31;                 binArr[32].Number = 32;                 binArr[33].Number = 33;
    //        binArr[31].Color = (int)Colors.Black;   binArr[32].Color = (int)Colors.Red;     binArr[33].Color = (int)Colors.Black;
    //        binArr[31].Row = 11;                    binArr[32].Row = 11;                    binArr[33].Row = 11;
    //        binArr[31].Column = 1;                  binArr[32].Column = 2;                  binArr[33].Column = 3;

    //        binArr[34].Number = 34;                 binArr[35].Number = 35;                 binArr[36].Number = 36;
    //        binArr[34].Color = (int)Colors.Red;     binArr[35].Color = (int)Colors.Black;   binArr[36].Color = (int)Colors.Red;
    //        binArr[34].Row = 12;                    binArr[35].Row = 12;                    binArr[36].Row = 12;
    //        binArr[34].Column = 1;                  binArr[35].Column = 2;                  binArr[36].Column = 3;
    //    }
    //    public Bin[] CreateWheel()
    //    {
    //        return binArr;
    //    }
    //}
//}

