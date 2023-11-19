using GamerManagement.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagement.Game_Component
{
    internal class Snippers : IPurchase
    {
        public void deletedPurchase(Gamer gamer)
        {
            Console.WriteLine("Transaction canceled");
        }

        public void purchase(Gamer gamer)
        {
            Console.WriteLine("Transaction succeed");
        }

        public void updatedPurchase(Gamer gamer)
        {
            Console.WriteLine("Transaction updated");
        }
    }
}
