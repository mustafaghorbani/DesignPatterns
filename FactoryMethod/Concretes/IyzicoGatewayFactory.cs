﻿using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    public class IyzicoGatewayFactory : IPaymentGatewayFactory
    {
        IPaymentGateway IPaymentGatewayFactory.CreatePaymentGateway()
        {
            return new IyzicoGateway();
        }
    }
}
