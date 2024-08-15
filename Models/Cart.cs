using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace itehaProject.Models
{
    [Serializable]
    public class Cart:CollectionBase
    {
        
        
        
        public Cart() { }

        public Cart(List<Products> items)
        {
            this.items = items;
        }

        private List<Products> items = new List<Products>();
        public Cart this[int index]
        {
            get
            {
                return (Cart)this.List[index];
            }
            set
            {
                this.List[index] = value;
            }
        }
        public int IndexOf(Cart cartItem)
        {
            if (cartItem != null)
            {
                return base.List.IndexOf(cartItem);
            }
            return -1;
        }

        public void Insert(int index, Products Product)
        {
            if (index <= List.Count && Product != null)
            {
                this.List.Insert(index, Product);
            }
        }

    }
}
