﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using OtripleS.Web.Api.Models.Foundations.Contacts;
using OtripleS.Web.Api.Models.Foundations.Users;

namespace OtripleS.Web.Api.Models.Foundations.UserContacts
{
    public class UserContact
    {
        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
