﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.AssignmentAttachments.Exceptions
{
    public class InvalidAssignmentAttachmentReferenceException : Exception
    {
        public InvalidAssignmentAttachmentReferenceException(Exception innerException)
            : base(message: "Invalid assignment attachment reference error occurred.", innerException) { }
    }
}
