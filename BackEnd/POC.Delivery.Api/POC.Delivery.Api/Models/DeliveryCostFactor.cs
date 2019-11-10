namespace POC.Delivery.Api.Models
{
    using System.Collections.Generic;

    public class DeliveryCostFactor
    {
        public string Service { get; set; }
        public decimal BaseCost { get; set; }
        public List<SeasonFactor> Factors { get; set; }
    }

    public class SeasonFactor
    {
        public List<int> Months { get; set; }
        public decimal Factor { get; set; }
    }
}
