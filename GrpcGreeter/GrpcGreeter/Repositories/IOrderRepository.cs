namespace GrpcGreeter.Repositories
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrder();
        public Task<string> SayHello(string message);
    }
}
