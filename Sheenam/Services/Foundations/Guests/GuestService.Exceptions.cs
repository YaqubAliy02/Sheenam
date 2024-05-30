//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using Sheenam.Models.Foundations.Guests;
using Sheenam.Models.Foundations.Guests.Exceptions;
using Xeptions;

namespace Sheenam.Services.Foundations.Guests
{
    public partial class GuestService
    {
        private delegate ValueTask<Guest> ReturningGuestFunction();

        private async ValueTask<Guest> TryCatch(ReturningGuestFunction returningGuestFunction)
        {
            try
            {
               return await returningGuestFunction();
            }
            catch (NullGuestException nullGuestException)
            {
               throw CreateAndLogValidationException(nullGuestException);
            }
        }

        private GuestValidationException CreateAndLogValidationException(Xeption exception)
        {
            var guestValidationException =
               new GuestValidationException(exception);

            this.loggingBroker.LogError(guestValidationException);

            throw guestValidationException;
        }
    }
}
