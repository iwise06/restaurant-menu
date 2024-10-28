using restaurant_menu;

class Program
{
	static void Main()
	{
		Menu menu = new();

		menu.AddMenuItem(new MenuItem("Blooming onion", "A large onion that's cut to resemble a flower, battered, and deep-fried", 7.99m, "Appetizer", true));
		menu.AddMenuItem(new MenuItem("Pizza", "Delicous cheese pizza", 14.99m, "Main Course", false));
		menu.AddMenuItem(new MenuItem("Cake", "Warm chocolate cake", 8.99m, "Dessert", true));
		menu.DisplayMenu();
	}
}