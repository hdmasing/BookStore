﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }

        public double Sum { get; set; }

        public DateTime DateCreated { get; private set; }
        public Boolean Paid { get; set; }

        public virtual ICollection<Book> Items { get; set; }
       

        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            Sum = 0;
            DateCreated = DateTime.Now;
            Items = new List<Book>();
        }

       public void AddToCart(Book book)
        {
            Items.Add(book);
            Sum += book.Price;
        }

        public void PayForCart(ShoppingCart cart)
        {
            Boolean ispaid = true;
            cart.Paid = ispaid;
        }
    }
}