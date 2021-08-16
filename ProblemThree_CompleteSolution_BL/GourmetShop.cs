using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public int ItemCode;
        public string ItemName;
        public abstract double PayPerPiece(int quantity);
        
        public abstract double PayPerWeight(int weight);

    public GourmetShop(int itemCode,string itemName )
    {
            this.ItemCode = itemCode;
            this.ItemName = itemName;
    }
    }
}