using BuilderService.Implementations;

namespace BuilderService.Interfaces
{
    public interface ICartBuilder
    {
        void AddItem(string item);
        void ApplyDiscount(decimal discount);
        Cart GetCart();
    }
}
