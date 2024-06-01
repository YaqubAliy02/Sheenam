//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using Xeptions;

namespace Sheenam.Models.Foundations.Guests.Exceptions
{
    public class GuestServiceException : Xeption
    {
        public GuestServiceException(Exception innerException)
            : base(message: "Guest service error occured, contact support",
                 innerException)
        { }
    }
}
