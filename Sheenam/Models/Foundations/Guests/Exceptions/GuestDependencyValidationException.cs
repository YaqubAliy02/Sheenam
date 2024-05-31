//------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//-----------------------------

using Xeptions;

namespace Sheenam.Models.Foundations.Guests.Exceptions
{
    public class GuestDependencyValidationException : Xeption
    {
        public GuestDependencyValidationException(Xeption innerException)
            : base(message: "Guest dependency validation error occured, fix the errors and try again",
                  innerException)
        { }
    }
}
