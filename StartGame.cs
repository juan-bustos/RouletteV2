using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteV2
{
    class StartGame
    {
        public StartGame()
        {
            Menu.WelcomeMenu();

            Wallet.AddMoney();
            Console.WriteLine("Enter any key to continue");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Wallet.WalletHover();
                Menu.MenuHover();

                Menu.MenuSelect();
                Console.WriteLine("Enter any key to place another bet");
                Console.ReadKey();
                Console.Clear();
            } while (true);

        }
    }
}
