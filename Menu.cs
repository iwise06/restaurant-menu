namespace restaurant_menu
{
	public class Menu
	{
		private List<MenuItem> Items { get; set; }
		public DateTime LastUpdated { get; private set; }

		public Menu()
		{
			Items = [];
			LastUpdated = DateTime.Now;
		}

		public void AddMenuItem(MenuItem item)
		{
			Items.Add(item);
			LastUpdated = DateTime.Now;
		}

		public void DisplayMenu()
		{
			Console.WriteLine("Menu:\n");
			foreach (var item in Items)
			{
				Console.WriteLine(item.ToString());
				Console.WriteLine();
			}
			Console.WriteLine($"Last Updated: {LastUpdated}");
		}
	}
}