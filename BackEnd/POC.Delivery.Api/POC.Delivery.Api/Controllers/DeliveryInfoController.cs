namespace POC.Delivery.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using POC.Delivery.Api.Models;
    using POC.Delivery.Api.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryInfoController : ControllerBase
    {
        private readonly IDeliveryInfoService _deliveryInfoService;

        public DeliveryInfoController(IDeliveryInfoService deliveryInfoService)
        {
            _deliveryInfoService = deliveryInfoService;

        }

        [HttpGet]
        public DeliveryInfo GetDeliveryInfo()
        {
            return _deliveryInfoService.GetDeliveryInfo();
        }
    }
}