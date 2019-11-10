using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using Moq;
using POC.Delivery.Api.Calculator;
using Xunit;

namespace POC.Delivery.Api.Tests
{
    public class DeliveryCostCalculatorTests : ServiceTestBase
    {
        public DeliveryCostCalculatorTests() : base()
        {

        }

        [Fact]
        public void callculate_cost()
        {
            // Arragne
            var sut = this.fixture.Create<DeliveryCostCalculator>();

            // Act
            var actual  = sut.CalculatDeliveryServiceCost("Motorbike", System.DateTime.Now);

            // Assert
            actual.Should().BeGreaterThan(0);
        }
    }
}
