using System;
using System.Collections.Generic;
using System.Text;

namespace ExPropHerancaA133.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; } //Taxa de alfândega

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee):base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name +" $ "+TotalPrice() + " (Customs fee: $" + CustomsFee + " ) ";
        }
    }
}
