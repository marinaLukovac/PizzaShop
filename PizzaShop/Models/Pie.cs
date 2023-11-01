namespace PizzaShop.Models
{
    public class Pie
    {
        public int PieID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal  Price { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }

        public Pie (int pieID, string name, string description, decimal price, bool isPieOfTheWeek, bool inStock)
        {
            PieID = pieID;
            Name = name;
            Description = description;
            Price = price;
            IsPieOfTheWeek = isPieOfTheWeek;
            InStock = inStock;
        }
    }
}
