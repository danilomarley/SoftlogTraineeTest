using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftlogTest.Entity
{
    public class Product
    {
        public Product(string code, string description, double price, bool active)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            this.Active = active;
        }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }
        public virtual bool Active { get; set; }
    }
}
