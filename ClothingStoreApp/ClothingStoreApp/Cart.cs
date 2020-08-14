using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreApp
{
    class Cart
    {
        private string Name;
        private Dictionary<string, Products> cart;

        public Cart()
        {
            //this.CusName = "Guest";
            this.cart = new Dictionary<string, Products>();
        }

        //public Cart(string CusName)
        //{
        //    this.CusName = CusName;
        //    this.cart = new Dictionary<string, Products>();
        //}

        public string CusName
        {
            get { return Name; }
            set { Name = value; }
        }

        public Dictionary<string, Products> ShoppingCart()
        {
            return cart;
        }

        public void AddToCart(Products p)
        {
            if (this.cart.ContainsKey(p.ProductID.ToString()))
            {
                int quantity = this.cart[p.ProductID.ToString()].Quantity + p.Quantity;
                this.cart[p.ProductID.ToString()].Quantity = quantity;
            }
            else this.cart.Add(p.ProductID.ToString(), p);
        }

        public void Update(Products p)
        {
            if (this.cart.ContainsKey(p.ProductID.ToString()))
            {
                this.cart[p.ProductID.ToString()].Quantity = p.Quantity;
            }
        }

        public void Delete(Products p)
        {
            if (this.cart.ContainsKey(p.ProductID.ToString()))
            {
                this.cart.Remove(p.ProductID.ToString());
            }
        }

        public void Clear()
        {
            cart.Clear();
        }
    }
}
