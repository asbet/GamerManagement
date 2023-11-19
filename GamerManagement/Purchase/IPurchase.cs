using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagement.Purchase
{
    internal interface IPurchase
    {
        void purchase(Gamer gamer);
        void updatedPurchase(Gamer gamer);
        void deletedPurchase(Gamer gamer);
    }
}
