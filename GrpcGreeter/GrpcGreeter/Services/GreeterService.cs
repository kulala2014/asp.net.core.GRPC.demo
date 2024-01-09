using Grpc.Core;
using GrpcGreeter;
using GrpcGreeter.Repositories;

namespace GrpcGreeter.Services
{
    public class GreeterService : OrderProcessing.OrderProcessingBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly IOrderRepository _orderRepository;
        public GreeterService(ILogger<GreeterService> logger, IOrderRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = _orderRepository.SayHello(request.Name).Result
            }); 
        }

        public override Task<OrderResponse> GetOrder(OrderRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OrderResponse 
            {
                Order = _orderRepository.GetOrder().Result
            });
        }
    }
}
