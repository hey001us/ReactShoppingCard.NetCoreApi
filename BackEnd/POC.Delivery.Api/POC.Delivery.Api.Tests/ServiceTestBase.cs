
namespace POC.Delivery.Api.Tests
{
    using AutoFixture;
    using AutoFixture.AutoMoq;
    using Bogus;
    using System.Linq;

    public abstract class ServiceTestBase
    {
        internal Faker faker;

        internal Fixture fixture;


        protected ServiceTestBase()
        {
            this.faker = new Faker();
            this.fixture = new Fixture();
            this.fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => this.fixture.Behaviors.Remove(b));
            this.fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            this.fixture.Customize(new AutoMoqCustomization());
        }
    }
}
