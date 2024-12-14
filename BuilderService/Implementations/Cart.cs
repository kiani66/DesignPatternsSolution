namespace BuilderService.Implementations
{
    public class Cart
    {
        public List<string> Items { get; private set; } = new List<string>();
        public decimal Discount { get; private set; }

        public void AddItem(string item)
        {
            Items.Add(item);
        }

        public void SetDiscount(decimal discount)
        {
            Discount = discount;
        }
    }
}
