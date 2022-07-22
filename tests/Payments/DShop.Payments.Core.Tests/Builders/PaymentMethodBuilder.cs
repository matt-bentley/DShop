﻿using DShop.Payments.Core.PaymentMethods.Entities;
using DShop.Payments.Core.PaymentMethods.ValueObjects;

namespace DShop.Payments.Core.Tests.Builders
{
    public class PaymentMethodBuilder
    {
        private string _name = "Credit Card";
        private Guid _customerId = Guid.NewGuid();
        private PaymentType _type = PaymentType.CreditCard; 

        public PaymentMethod Build()
        {
            return PaymentMethod.Create(_name, _customerId, _type);
        }

        public PaymentMethodBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
    }
}
