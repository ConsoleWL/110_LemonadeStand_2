using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        public string name;
        public Customer()
        {
            name = "Customer";
        }

        public void Purchase(Player player, Recipe recipe ) // maybe add weather conditions
        {
            player.inventory.cups.RemoveAt(0);
            player.wallet.AcceptMoney(recipe.price);
        }
    }
}
