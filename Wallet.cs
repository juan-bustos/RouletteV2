using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteV2
{
    class Wallet
    {
        public static int addMoney;
        public static int myMoney;
        public static int betMoney;

        public static int AddMoney()
        {
            AddMoney:
            Console.WriteLine("Enter a $ amount to add to you wallet");
            addMoney = myMoney + int.Parse(Console.ReadLine());
            if (addMoney <= 0)
            {
                Console.WriteLine("You didn't add any money. Try again");
                goto AddMoney;
            }
            myMoney = addMoney;
            Console.WriteLine($"You added ${addMoney} to your wallet");
            return myMoney;
        }
        public static int Bet()
        {
            BetMoney:
            Console.Write("How much do you want to bet? $");
            betMoney = int.Parse(Console.ReadLine());
            if (betMoney <= 0)
            {
                Console.WriteLine("You didn't bet any money. Place a bet");
                goto BetMoney;
            }
            else if (betMoney > myMoney)
            {
                Console.WriteLine("You don't have enough money, go home");
                goto BetMoney;
            }
            return betMoney;
        }
        public static void WalletHover()
        {
            RouletteTable.DrawBoard();
            Console.WriteLine($"Wallet: ${Wallet.myMoney}");
        }
    }
}
