using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteV2
{
    public class Menu
    {
        public static void WelcomeMenu()
        {
            WelcomeMenu:
            Console.WriteLine("Welcome! Would You like to play Roulette?");
            Console.WriteLine("Press [Y/N]");
            string selection = Console.ReadLine().ToUpper();
            if (selection == "Y")
            {
                Console.Clear();
                RouletteTable.DrawBoard();
            }
            else if (selection == "N")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You have input the wrong value. Please select 'Y' or 'N'");
                goto WelcomeMenu;
            }           
        }
        public static void MenuHover()
        {
            Console.WriteLine("Select a menu option to place a bet:  ");
        }
        public static void MenuSelect()
        {
            int menuSelection = new int();
                menuSelection = int.Parse(Console.ReadLine());

            if (menuSelection == 1)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.NumbersBet();
            }
            if (menuSelection == 2)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.EvensOdds();
            }
            if (menuSelection == 3)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.RedOrBlack();
            }
            if (menuSelection == 4)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.LowsAndHighs();
            }
            if (menuSelection == 5)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.DozensBet();
            }
            if (menuSelection == 6)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.ColumnsBet();
            }
            if (menuSelection == 7)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.StreetsBet();
            }
            if (menuSelection == 8)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.SixNumbersBet();
            }
            if (menuSelection == 9)
            {
                Console.Clear();
                Wallet.WalletHover();
                Bets.SplitBet();
            }
        }
    }
}
