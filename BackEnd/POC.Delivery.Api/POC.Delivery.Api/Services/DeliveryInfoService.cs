using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using POC.Delivery.Api.Calculator;
using POC.Delivery.Api.Models;

namespace POC.Delivery.Api.Services
{
    public class DeliveryInfoService : IDeliveryInfoService
    {
        private readonly IDeliveryCostCalculator _deliveryCostCalculator;
        public DeliveryInfoService(IDeliveryCostCalculator deliveryCostCalculator)
        {
            _deliveryCostCalculator = deliveryCostCalculator;
        }
        public DeliveryInfo GetDeliveryInfo()
        {
            var fixture = new Fixture();

            var deliveryInfo = fixture.Create<DeliveryInfo>();

            deliveryInfo.Aircraft.Cost = _deliveryCostCalculator.CalculatDeliveryServiceCost(deliveryInfo.Aircraft.ServiceType
                                                                                            , deliveryInfo.Aircraft.DateOfArrival);
            deliveryInfo.Motoerbike.Cost = _deliveryCostCalculator.CalculatDeliveryServiceCost(deliveryInfo.Aircraft.ServiceType
                                                                                            , deliveryInfo.Motoerbike.DeliveryDate);
            deliveryInfo.Train.Cost = _deliveryCostCalculator.CalculatDeliveryServiceCost(deliveryInfo.Aircraft.ServiceType
                                                                                            , deliveryInfo.Train.DateOfArrival);
            return deliveryInfo;
        }
    }
}
