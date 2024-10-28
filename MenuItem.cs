namespace restaurant_menu
{
    public class MenuItem(string name, string description, decimal price, string category, bool isNew)
    {
        public string Name { get; private set; } = name;
        public string Description { get; private set; } = description;
        public decimal Price { get; private set; } = price;
        public string Category { get; private set; } = category;
        public bool IsNew { get; private set; } = isNew;

        public override string ToString()
        {
            return $"{Name} - {Category} - ${Price}\n{Description}\n" +
                   (IsNew ? "New Item!" : "");
        }
    }
}