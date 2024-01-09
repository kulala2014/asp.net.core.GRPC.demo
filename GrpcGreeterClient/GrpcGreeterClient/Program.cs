using Grpc.Net.Client;
using GrpcGreeterClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

using var channel = GrpcChannel.ForAddress("https://localhost:7098");
var client = new OrderProcessing.OrderProcessingClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);

var data = new OrderRequest { OrderId = 1 };
var response = await client.GetOrderAsync(data);
Console.WriteLine($"Order Info: Order Id: {response.Order.OrderId}, Order Quantity: {response.Order.OrderQuantity}, Order ShipAddress: {response.Order.ShipAddress}, ShipCity: {response.Order.ShipCity}, ShipPostalCode: {response.Order.ShipPostalCode}");

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
