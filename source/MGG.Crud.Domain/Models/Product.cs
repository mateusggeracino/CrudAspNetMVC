using System;

namespace MGG.Crud.Domain.Models
{
    public class Product : Entity<Product>
    {
        protected Product() { }

        public Product(string name, string description, DateTime registerDate)
        {
            Name = name;
            Description = description;
            RegisterDate = registerDate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime RegisterDate { get; private set; }


        protected override bool IsValid()
        {
            return true;
        }
    }
}