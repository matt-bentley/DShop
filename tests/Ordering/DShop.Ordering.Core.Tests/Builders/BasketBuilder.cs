﻿using DShop.Ordering.Core.Baskets.Entities;

namespace DShop.Ordering.Core.Tests.Builders
{
    public class BasketBuilder
    {
        private Guid _customerId = Guid.NewGuid();

        public Basket Build()
        {
            return Basket.Create(_customerId);
        }

        public BasketBuilder WithCustomerId(Guid id)
        {
            _customerId = id;
            return this;
        }
    }
}
