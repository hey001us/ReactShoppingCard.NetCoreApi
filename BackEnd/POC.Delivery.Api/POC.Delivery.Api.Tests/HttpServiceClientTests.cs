
namespace POC.Delivery.Api.Tests
{
    using System.Threading.Tasks;
    using AutoFixture;
    using FluentAssertions;
    using POC.Delivery.Api.ServiceClient;
    using Xunit;

    public class HttpServiceClientTests : ServiceTestBase
    {
        public HttpServiceClientTests() : base()
        {

        }

        [Fact]
        public async Task call_http_client_returns_books()
        {
            // Arragne
            var sut = this.fixture.Create<BookHttpServiceClient>();

            // Act
            var actual = await sut.GetBooks();

            // Assert
            actual.items.Should().HaveCountGreaterOrEqualTo(1);
            
        }
    }
}
