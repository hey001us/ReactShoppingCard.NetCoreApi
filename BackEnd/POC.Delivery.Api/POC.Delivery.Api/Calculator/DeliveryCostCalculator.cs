namespace POC.Delivery.Api.Calculator
{
    using Newtonsoft.Json;
    using POC.Delivery.Api.Helpers;
    using POC.Delivery.Api.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeliveryCostCalculator : IDeliveryCostCalculator
    {
        public decimal CalculatDeliveryServiceCost(string sericeType, DateTime deliveryDate)
        {
            var delivieryCostFactorJson = FileReaderHelper.ReadFile(@"Data\deliviery-cost-mock.json");
            var delivieryCostFactorList = JsonConvert.DeserializeObject<List<DeliveryCostFactor>>(delivieryCostFactorJson);

            var delivieryCostFactor = delivieryCostFactorList
                                        .Where(x => x.Service.Equals(sericeType, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            var seasonFactor = delivieryCostFactor.Factors.Where(x => x.Months.Contains(deliveryDate.Month)).FirstOrDefault();

            var deliveryCost = (delivieryCostFactor.BaseCost * seasonFactor.Factor);

            return deliveryCost;
        }
    }
}
