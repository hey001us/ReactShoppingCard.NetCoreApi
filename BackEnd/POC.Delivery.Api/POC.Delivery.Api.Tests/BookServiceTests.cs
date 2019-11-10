namespace POC.Delivery.Api.Tests
{
    using System.Threading.Tasks;
    using AutoFixture;
    using FakeItEasy;
    using FluentAssertions;
    using POC.Delivery.Api.ServiceClient;
    using POC.Delivery.Api.Services;
    using Xunit;

    public class BookServiceTests : ServiceTestBase
    {
        private readonly BookService _sut;
        private readonly IServiceClient _fakeServiceClient;

        public BookServiceTests() : base()
        {
            _fakeServiceClient = A.Fake<IServiceClient>();
            _sut = new BookService(_fakeServiceClient);
        }

        [Fact]
        public async Task GetShoppingBooksReturnsBooks()
        {
            // Arragne
            var fackRootObject = this.fixture.Create<Models.RootObject>();
            A.CallTo(() => _fakeServiceClient.GetBooks())
                    .Returns(fackRootObject);

            // Act
            var actual = await _sut.GetShoppingBooks();

            // Assert
            actual.Should().HaveCountGreaterOrEqualTo(1);
        }
    }
}
