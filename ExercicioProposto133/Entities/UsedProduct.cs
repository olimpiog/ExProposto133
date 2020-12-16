using System;
using System.Globalization;
using System.Text;

namespace ExercicioProposto133.Entities
{
    class UsedProduct : Product
    {
        public DateTime DateManufacture { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime dateManufacture) : base(name, price)
        {
            DateManufacture = dateManufacture;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: "+DateManufacture.ToString("dd/MM/yyyy"));
            sb.Append(")");
            return sb.ToString();
        }
    }

}
