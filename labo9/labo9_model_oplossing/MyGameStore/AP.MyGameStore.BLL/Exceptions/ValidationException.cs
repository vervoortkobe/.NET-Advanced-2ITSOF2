using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.BLL.Exceptions
{
    public class ValidationException : Exception
    {

        public ValidationException() : base()
        {

        }

        public ValidationException(string message, ValidationError errorCode) : base(message)
        {
            this.ErrorCode = errorCode;
        }

        public ValidationError ErrorCode { get; private set; }

        public enum ValidationError
        {
            NameTooLong,
            NameNotUnique,
            PageLengthGreaterThan20,
            PageNumberSmallerThan1,
            EmployeesInStore,
            AgeGreaterThan67,
            AgeSmallerThan16,
            EmailAddressInvalid


        }
    }
}
