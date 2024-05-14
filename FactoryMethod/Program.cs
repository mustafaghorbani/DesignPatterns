

using FactoryMethod.Concretes;
using FactoryMethod.Interfaces;

// Client code
IPaymentGatewayFactory factory = new PaparaGatewayFactory();
IPaymentGateway gateway = factory.CreatePaymentGateway();
gateway.ProcessPayment(100.00m);