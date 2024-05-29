//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------
using Sheenam.Brokers.Loggings;
using Sheenam.Brokers.Storages;
using Sheenam.Models.Foundations.Guests;
using Sheenam.Models.Foundations.Guests.Exceptions;

namespace Sheenam.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public GuestService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Guest> AddGuestAsync(Guest guest)
        {
            if (guest == null)
                throw new GuestValidationException(new NullGuestException());

            return guest;
        }
    }
}
