using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSBL
{
   public abstract class GourmetShop
    {
        public int ItemCode { get; set; }
        public String ItemName { get; set; }
        public Dictionary<int,double> ItemPrice { get; set; }
        public GourmetShop(int icode , string iName ) 
        {
            ItemCode = icode;
            ItemName = iName;
            ItemPrice = new Dictionary<int,double>();
        }
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int Weight);
    } 
}
