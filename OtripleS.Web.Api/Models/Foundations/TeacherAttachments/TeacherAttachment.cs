﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using OtripleS.Web.Api.Models.Foundations.Attachments;
using OtripleS.Web.Api.Models.Foundations.Teachers;

namespace OtripleS.Web.Api.Models.Foundations.TeacherAttachments
{
    public class TeacherAttachment
    {
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public Guid AttachmentId { get; set; }
        public Attachment Attachment { get; set; }

        public string Notes { get; set; }
    }
}
