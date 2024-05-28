//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using FluentAssertions;
using Moq;
using Sheenam.Brokers.Storages;
using Sheenam.Models.Foundations.Guests;
using Sheenam.Services.Foundations.Guests;

namespace Sheenam.API.Tests.Unit.Services.Foundation.Guests
{
    public partial class GuestServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IGuestService guestService;

        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.guestService = 
                new GuestService(storageBroker: this.storageBrokerMock.Object);
        }

        [Fact]
        public async Task ShouldAddGuestAsync()
        {
            //Arrange
            Guest randomGuest = new Guest
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Address = "Navbahor 107",
                DateOfBirth = new DateTimeOffset(),
                Email = "yaqubaliy02@gmail.com",
                Gender = GenderType.Male,
                PhoneNumber = "1234567890",
            };
            this.storageBrokerMock.Setup(broker =>
            broker.InsertGuestAsync(randomGuest))
                .ReturnsAsync(randomGuest);
            //Act
            Guest actual = await this.guestService.AddGuestAsync(randomGuest);
            //Assert
            actual.Should().BeEquivalentTo(randomGuest);

        }
    }
}
