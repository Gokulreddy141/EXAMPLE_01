using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSBL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double TotalBillValue { get; set; }
        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice) : base(iCode, iName)
        {
            ItemPrice = iPrice;
        }
        public override double PayPerPiece(int quantity)
        {
            if (ItemPrice.ContainsKey(1))
            {
                TotalBillValue = quantity * ItemPrice[1];
            }
            return TotalBillValue;
        }
        public override double PayPerWeight(int Weight)
        {
            if (ItemPrice.ContainsKey(2))
            {
                TotalBillValue = Weight * ItemPrice[2];
            }
            return TotalBillValue;
        }
        public double TaxOnTotalBill()
        {
            return TotalBillValue * 0.05; // Assuming 5% tax
        }
    }
}
