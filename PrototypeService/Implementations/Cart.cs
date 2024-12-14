using PrototypeService.Interfaces;

namespace PrototypeService.Implementations
{
    public class Cart : IPrototype<Cart>
    {
        public List<string> Items { get; private set; } = new List<string>();
        public decimal Discount { get; private set; }

        public Cart(List<string> items, decimal discount)
        {
            Items = new List<string>(items);
            Discount = discount;
        }

        // متد کلون برای تولید نمونه جدید از Cart
        public Cart Clone()
        {
            return new Cart(this.Items, this.Discount);
        }

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
