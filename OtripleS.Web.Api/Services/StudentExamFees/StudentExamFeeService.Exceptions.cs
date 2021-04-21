﻿//---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
//----------------------------------------------------------------

using System;
using System.Threading.Tasks;
using EFxceptions.Models.Exceptions;
using Microsoft.Data.SqlClient;
using OtripleS.Web.Api.Models.StudentExamFees;
using OtripleS.Web.Api.Models.StudentExamFees.Exceptions;

namespace OtripleS.Web.Api.Services.StudentExamFees
{
    public partial class StudentExamFeeService
    {
        private delegate ValueTask<StudentExamFee> ReturningStudentExamFeeFunction();

        private async ValueTask<StudentExamFee> TryCatch(
            ReturningStudentExamFeeFunction returningStudentExamFeeFunction)
        {
            try
            {
                return await returningStudentExamFeeFunction();
            }
            catch (NullStudentExamFeeException nullStudentExamFeeException)
            {
                throw CreateAndLogValidationException(nullStudentExamFeeException);
            }
            catch (InvalidStudentExamFeeException invalidStudentExamFeeInputException)
            {
                throw CreateAndLogValidationException(invalidStudentExamFeeInputException);
            }
            catch (DuplicateKeyException duplicateKeyException)
            {
                var alreadyExistsStudentExamFeeException =
                    new AlreadyExistsStudentExamFeeException(duplicateKeyException);

                throw CreateAndLogValidationException(alreadyExistsStudentExamFeeException);
            }
            catch (SqlException sqlException)
            {
                throw CreateAndLogCriticalDependencyException(sqlException);
            }
        }

        private StudentExamFeeValidationException CreateAndLogValidationException(Exception exception)
        {
            var StudentExamFeeValidationException = new StudentExamFeeValidationException(exception);
            this.loggingBroker.LogError(StudentExamFeeValidationException);

            return StudentExamFeeValidationException;
        }

        private StudentExamFeeDependencyException CreateAndLogCriticalDependencyException(Exception exception)
        {
            var StudentExamFeeDependencyException = new StudentExamFeeDependencyException(exception);
            this.loggingBroker.LogCritical(StudentExamFeeDependencyException);

            return StudentExamFeeDependencyException;
        }
    }
}
