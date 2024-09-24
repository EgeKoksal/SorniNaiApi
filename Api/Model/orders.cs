using System.Numerics;

namespace Api.Model
{

    public class Cart
    {
        public decimal Totalprice { get; set; }
        public required List<CartItem> Products { get; set; }
    }

    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
    }
}