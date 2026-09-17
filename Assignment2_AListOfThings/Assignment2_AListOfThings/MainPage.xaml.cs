namespace Assignment2_AListOfThings
{
    public partial class MainPage : ContentPage
    {
        List<double> prices = new List<double>
        {
            10.99,
            5.49,
            3.75,
            12.01,
            1.50,
            50.89,
            12.75,
            30.00,
            8.99,
            17.25
        };

        List<string> itemNames = new List<string>
        {
            "Milk",
            "Bread",
            "Eggs",
            "Chicken",
            "Rice",
            "Pasta",
            "Detergent",
            "Soap",
            "Shampoo",
            "Toothpaste"
        };

        public MainPage()
        {
            InitializeComponent();
            priceList.ItemsSource = prices;
            itemList.ItemsSource = itemNames;
        }

        private void OnTotalClicked(object? sender, EventArgs e)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            totalLabel.Text = total.ToString();
        }
    }
}
