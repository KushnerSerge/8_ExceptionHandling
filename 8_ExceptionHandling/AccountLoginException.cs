using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _8_ExceptionHandling
{
    public class AccountLoginException : Exception
    {
        public AccountLoginException()
        {
        }

        public AccountLoginException(string? message) : base(message)
        {
        }

        public AccountLoginException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AccountLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
