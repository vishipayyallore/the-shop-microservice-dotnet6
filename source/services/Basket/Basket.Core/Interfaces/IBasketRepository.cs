using Basket.Core.Entities;

namespace Basket.Core.Interfaces
{

    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string userName);

        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);

        Task DeleteBasket(string userName);
    }

}
