
namespace POC.Delivery.Api.Models
{
    using System;

    public class DeliveryInfo
    {
        public MotorbikeDeliveryInfo Motoerbike { get; set; }
        public TrainDeliveryInfo Train { get; set; }
        public AircraftDeliveryInfo Aircraft { get; set; }
    }

    public abstract class DeliveryInfoBase
    {
        public abstract string ServiceType { get; }
        public decimal Cost { get; set; }
    }

    public class MotorbikeDeliveryInfo : DeliveryInfoBase
    {
        public override string ServiceType => "Motorbike";
        public string DriverName { get; set; }
        public string Mobile { get; set; }
        public DateTime DeliveryDate { get; set; }
    }

    public class TrainDeliveryInfo : DeliveryInfoBase
    {
        public override string ServiceType => "Train";
        public string TrainNumber { get; set; }
        public string StationOfArrival { get; set; }
        public DateTime DateOfArrival { get; set; }
    }

    public class AircraftDeliveryInfo : DeliveryInfoBase
    {
        public override string ServiceType => "Aircraft";
        public string FlightNumber { get; set; }
        public string GateOfArrival { get; set; }
        public DateTime DateOfArrival { get; set; }
    }
}
