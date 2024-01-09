
namespace GrpcGreeter.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<Order> GetOrder()
        {
            return await Task.FromResult(new Order
            {
                OrderId = 1,
                ShipAddress = "Banjara Hills",
                ShipCity = "Hyderabad",
                ShipPostalCode = "500034",
                OrderQuantity = 100
            });
        }

        public async Task<string> SayHello(string message)
        {
            return await Task.FromResult("Hello " + message);
        }
    }
}
