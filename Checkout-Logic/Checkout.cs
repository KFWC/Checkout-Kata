using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout_Logic
{
    public class Checkout : ICheckout
    {
        private Dictionary<string,int> Items { get; set; }
        private Dictionary<string,int> CostPrice { get; set; }
        private Dictionary<string,int> SpecialQty { get; set; }
        private Dictionary<string,int> SpecialPrice { get; set; }

        public Checkout()
        {
            Items = new Dictionary<string, int>();

            CostPrice = new Dictionary<string, int>() { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
            SpecialQty = new Dictionary<string, int>() { { "A", 3 }, { "B", 2 }, { "C", 1 }, { "D", 1 } };
            SpecialPrice = new Dictionary<string, int>() { { "A", 130 }, { "B", 45 }, { "C", 20 }, { "D", 15 } };
        }

        public void Scan(string item)
        {
            if (Items.ContainsKey(item))
            {
                Items[item] = (Items[item] + 1);
            }
            else
            {
                Items.Add(item, 1);
            }
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;

            foreach(string SKU in Items.Keys)
            {
                totalPrice += ((Items[SKU] / SpecialQty[SKU]) * SpecialPrice[SKU]);
                totalPrice += ((Items[SKU] - (Items[SKU] / SpecialQty[SKU]) * SpecialQty[SKU]) * CostPrice[SKU]);
            }
            return totalPrice;
        }
    }
}
