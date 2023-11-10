namespace PizzaShop.Models
{

    public class CategoryRepository: ICategoryRepository
    {
        private readonly Category[] _categories = 
            { 
                new Category(1, "veganska", "opis veganske categorije"), 
                new Category(2, "italijanska", "opis italijanske categorije"),
                new Category(3, "spanska", "opis spanske categorije")
            };
        public IEnumerable<Category> Categories
        {
            get { return _categories; }
        }
        public Category? GetCategoryById(int id)
        {
            foreach(Category category in Categories)
            {
                if (category.CategoryID == id)
                {
                    return category;
                }
            }
            return null;
        }
    }
}
