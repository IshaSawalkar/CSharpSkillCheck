using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double totalBillValue;

        public GourmetOrganicShop(int ItemCode, string ItemName,Dictionary<int,double> iPrice):base(ItemCode,ItemName)
        {
            _ = this.ItemName;
            _ = this.ItemCode;


        }

       
    }
}
