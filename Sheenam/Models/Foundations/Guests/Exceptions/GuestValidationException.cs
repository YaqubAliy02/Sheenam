//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using Xeptions;

namespace Sheenam.Models.Foundations.Guests.Exceptions
{
    public class GuestValidationException : Xeption
    {
        public GuestValidationException(Xeption innerException)
        : base(message: "Guest validation error ocurred, fix the errors and try again",
             innerException)
        { }
    }
}
