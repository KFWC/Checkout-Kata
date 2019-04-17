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

        public Checkout()
        {
            Items = new Dictionary<string, int>();
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

            if (Items.Count > 0)
            {
                int specialQty = (Items["A"] / 3);

                totalPrice = (specialQty * 130 + ((Items["A"] - (specialQty * 3)) * 50));
            }

            return totalPrice;
        }
    }
}
