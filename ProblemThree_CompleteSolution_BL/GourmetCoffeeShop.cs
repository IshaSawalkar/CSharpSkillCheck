using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {
        public GourmetCoffeeShop(int itemCode, string itemName, Dictionary<int, double> coffeePriceDict) : base(itemCode, itemName)
        {
            CoffeePriceDict = coffeePriceDict;
        }

        public Dictionary<int, double> CoffeePriceDict { get; }
    }
}
