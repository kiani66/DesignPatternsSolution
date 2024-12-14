using BuilderService.Interfaces;

namespace BuilderService.Implementations
{
    public class CartBuilder : ICartBuilder
    {
        private Cart _cart = new Cart();

        public void AddItem(string item)
        {
            _cart.AddItem(item);
        }

        public void ApplyDiscount(decimal discount)
        {
            _cart.SetDiscount(discount);
        }

        public Cart GetCart()
        {
            Cart result = _cart;
            _cart = new Cart(); // Reset for the next build
            return result;
        }
    }
}
