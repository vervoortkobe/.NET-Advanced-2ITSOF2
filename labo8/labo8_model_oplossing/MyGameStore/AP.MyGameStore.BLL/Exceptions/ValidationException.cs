using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.MyGameStore.BLL.Exceptions
{
    public class ValidationException : Exception
    {
        public ErrorCode Code { get; private set; }

        public ValidationException() : base()
        {

        }

        public ValidationException(string message, ErrorCode code) : base(message)
        {
            this.Code = code;
        }

        public enum ErrorCode
        {
            AgeGreaterThan67,
            AgeSmallerThan16,
            EmailInvalid,
            PageLengthGreaterThan20,
            PageNumberSmallerThan1,
            NameNotUnique,
            StoreNotFound,
            StillEmployeesInStore
        }
    }
}
