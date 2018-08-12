﻿using System;
using System.Runtime.Serialization;

namespace fido2NetLib
{
    [Serializable]
    internal class Fido2VerificationException : Exception
    {
        public Fido2VerificationException()
        {
        }

        public Fido2VerificationException(string message) : base(message)
        {
        }

        public Fido2VerificationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Fido2VerificationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}