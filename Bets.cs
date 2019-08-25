using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteV2
{
    class Bets
    {
        public static void NumbersBet()
        {
            Console.WriteLine("Choose a number to bet on");
            string numberBet = Console.ReadLine();
            Wallet.Bet();

            if (numberBet == RouletteWheel.SpinRouletteWheel())
            {
                Wallet.myMoney += Wallet.betMoney * 35;
                Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }
            else
            {
                Wallet.myMoney -= Wallet.betMoney;
                Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }
        }
        public static void EvensOdds()
        {
            Console.WriteLine("Choose evens or odds");
            string evenOddBet = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());

            if (evenOddBet == "evens" && checkWheelNumber != int.Parse("0") && checkWheelNumber != int.Parse("00"))
            {
                if (checkWheelNumber % 2 == 0)
                {
                    Wallet.myMoney += Wallet.betMoney;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else if (checkWheelNumber % 2 == 1)
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            else if (evenOddBet == "odds" && checkWheelNumber != int.Parse("0") && checkWheelNumber != int.Parse("00"))
            {                            
                if (checkWheelNumber % 2 == 1)
                {
                    Wallet.myMoney += Wallet.betMoney;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else if (checkWheelNumber % 2 == 0)
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
        }
        public static void RedOrBlack ()
        {
            Console.WriteLine("Choose red or black");
            string redOrBlack = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());
            string color = RouletteWheel.binColor[checkWheelNumber];

            if (redOrBlack == "red")
            {
                if (color == "Red")
                {
                    Wallet.myMoney += Wallet.betMoney;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            else if (redOrBlack == "black")
            {
                if (color == "Black")
                {
                    Wallet.myMoney += Wallet.betMoney;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            else if (redOrBlack == "Green")
            {
                Wallet.myMoney -= Wallet.betMoney;
                Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }
        }
        public static void LowsAndHighs ()
        {
            Console.WriteLine("Choose low or high");
            string lowOrHigh = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());
            if (lowOrHigh == "low")
            {
                if (checkWheelNumber <= 18 && checkWheelNumber> 0)
                {
                    Wallet.myMoney += Wallet.betMoney;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            else if (lowOrHigh == "high")
            {
                if (checkWheelNumber >= 19)
                {
                    Wallet.myMoney += Wallet.betMoney;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
        }
        public static void DozensBet()
        {
            Console.WriteLine("Type 1st, 2nd or 3rd dozen to place a dozens bet");
            string dozensBet = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());
            if (dozensBet == "1st")
            {
                if (((checkWheelNumber-1)/12) +1 == 1)
                {
                    Wallet.myMoney += Wallet.betMoney * 2;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 2}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (dozensBet == "2nd")
            {
                if (((checkWheelNumber - 1) / 12) + 1 == 2)
                {
                    Wallet.myMoney += Wallet.betMoney * 2;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 2}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (dozensBet == "3rd")
            {
                if (((checkWheelNumber - 1) / 12) + 1 == 3)
                {
                    Wallet.myMoney += Wallet.betMoney * 2;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 2}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
        }
        public static void StreetsBet()
        {
            Console.WriteLine("Choose 1-12 to place a \"streets\" bet");
            string streetsBet = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());

            if (streetsBet == "1")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 1)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "2")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 2)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "3")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 3)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "4")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 4)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "5")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 5)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "6")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 6)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "7")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 7)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "8")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 8)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "9")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 9)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "10")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 10)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "11")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 11)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (streetsBet == "12")
            {
                if (((checkWheelNumber - 1) / 3) + 1 == 12)
                {
                    Wallet.myMoney += Wallet.betMoney * 11;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 11}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
        }
        public static void ColumnsBet()
        {
            Console.WriteLine("Type 1st, 2nd or 3rd column to place a columns bet");
            string columnsBet = Console.ReadLine().ToLower();
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());

            while (checkWheelNumber > 3)
            {
                checkWheelNumber -= 3;
            }

            if (columnsBet == "1st")
            {
                if (checkWheelNumber == 1)
                {
                    Wallet.myMoney += Wallet.betMoney * 2;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 2}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (columnsBet == "2nd")
            {
                if (checkWheelNumber == 2)
                {
                    Wallet.myMoney += Wallet.betMoney * 2;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 2}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
            if (columnsBet == "3rd")
            {
                if (checkWheelNumber == 3)
                {
                    Wallet.myMoney += Wallet.betMoney * 2;
                    Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 2}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
                else
                {
                    Wallet.myMoney -= Wallet.betMoney;
                    Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
                }
            }
        }
        public static void SixNumbersBet()
        {
            RowBet:
            Console.WriteLine("Select 1 for rows 1 and 4, 4 for rows 4 and 7, 7 for rows 7 and 10, 10 for rows 10 and 13 .... for a six numbers bet");
            int sixNumbersBet = int.Parse(Console.ReadLine());
            if (sixNumbersBet != 1 && sixNumbersBet != 4 && sixNumbersBet != 7 && sixNumbersBet != 10 && sixNumbersBet != 13 && sixNumbersBet != 16 && sixNumbersBet != 19 && sixNumbersBet != 22 && sixNumbersBet != 25 && sixNumbersBet != 28 && sixNumbersBet != 31 && sixNumbersBet != 34)
            {
                Console.WriteLine("You didn't select a valid row. Try again");
                goto RowBet;
            }
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());
            if (checkWheelNumber != 0 && (checkWheelNumber == sixNumbersBet || checkWheelNumber == sixNumbersBet + 1 || checkWheelNumber == sixNumbersBet + 2 || checkWheelNumber == sixNumbersBet + 3 ||
                checkWheelNumber == sixNumbersBet + 4 || checkWheelNumber == sixNumbersBet + 5 || checkWheelNumber == sixNumbersBet + 6 ))
            {
                Wallet.myMoney += Wallet.betMoney * 5;
                Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 5}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }
            else
            {
                Wallet.myMoney -= Wallet.betMoney;
                Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }        
        }
        public static void SplitBet()
        {
            SplitBet:
            Console.WriteLine("Select 2 numbers that are next to each other. IE: 1 and 2, 2 and 5, or 0 and 00 ");
            int firstSplitNumber = int.Parse(Console.ReadLine());
            int secondSplitNumber = int.Parse(Console.ReadLine());
            if ((firstSplitNumber % 3 == 0 && secondSplitNumber == firstSplitNumber - 3 || secondSplitNumber == firstSplitNumber + 3 || firstSplitNumber == firstSplitNumber - 1)
                || ((firstSplitNumber + 1) % 3 == 0 && secondSplitNumber == firstSplitNumber - 3 || secondSplitNumber == firstSplitNumber + 3 || firstSplitNumber == firstSplitNumber - 1 
                || firstSplitNumber == firstSplitNumber + 1)
                || ((firstSplitNumber + 2) % 3 == 0 && secondSplitNumber == firstSplitNumber - 3 || secondSplitNumber == firstSplitNumber + 3 || firstSplitNumber == firstSplitNumber + 1))
            {
                goto ActualBet;
            }
            else
            {
                Console.WriteLine("You didn't select a proper split. Try again!");
                goto SplitBet;
            }
            ActualBet:
            Wallet.Bet();
            int checkWheelNumber = int.Parse(RouletteWheel.SpinRouletteWheel());
            if (checkWheelNumber == firstSplitNumber || checkWheelNumber == secondSplitNumber)
            {
                Wallet.myMoney += Wallet.betMoney * 17;
                Console.WriteLine($"Congratulations you won ${Wallet.betMoney * 17}! You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }
            else
            {
                Wallet.myMoney -= Wallet.betMoney;
                Console.WriteLine($"You lost ${Wallet.betMoney}, You now have ${Wallet.myMoney}! \nTry your hand on another bet?");
            }
        }
    }
}
