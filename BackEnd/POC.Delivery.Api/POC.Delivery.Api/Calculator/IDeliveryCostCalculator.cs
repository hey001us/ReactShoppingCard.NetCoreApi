namespace POC.Delivery.Api.Calculator
{
    using System;

    public interface IDeliveryCostCalculator
    {
        decimal CalculatDeliveryServiceCost(string sericeType, DateTime deliveryDate);
    }
}
