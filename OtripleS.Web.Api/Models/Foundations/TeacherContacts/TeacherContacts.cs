﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using OtripleS.Web.Api.Models.Foundations.Contacts;
using OtripleS.Web.Api.Models.Foundations.Teachers;

namespace OtripleS.Web.Api.Models.Foundations.TeacherContacts
{
    public class TeacherContact
    {
        public Guid ContactId { get; set; }
        public Contact Contact { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
