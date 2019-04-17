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
            int totalPrice = 0, costPrice = 0, specialQty = 1, specialPrice = 0;

            foreach(string SKU in Items.Keys)
            {
                switch(SKU)
                {
                    case "A":
                        costPrice = 50;
                        specialQty = 3;
                        specialPrice = 130;
                        break;
                    case "B":
                        costPrice = 30;
                        specialQty = 2;
                        specialPrice = 45;
                        break;
                    case "C":
                        costPrice = 20;
                        specialQty = 1;
                        specialPrice = 20;
                        break;
                    case "D":
                        costPrice = 15;
                        specialQty = 1;
                        specialPrice = 15;
                        break;
                }

                totalPrice += ((Items[SKU] / specialQty) * specialPrice);
                totalPrice += ((Items[SKU] - (Items[SKU] / specialQty) * specialQty) * costPrice);
            }
            return totalPrice;
        }
    }
}
