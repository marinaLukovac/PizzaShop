namespace PizzaShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Category(int id, string name, string description)
        {
            CategoryID = id;
            CategoryName = name;
            Description = description;
        }
    }
}
