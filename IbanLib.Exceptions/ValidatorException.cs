﻿using System;

namespace IbanLib.Exceptions
{
    /// <summary>
    ///     ValidatorException class.
    /// </summary>
    public class ValidatorException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:IbanLib.Exceptions.ValidatorException" /> class.
        /// </summary>
        public ValidatorException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:IbanLib.Exceptions.ValidatorException" /> class with a
        ///     specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public ValidatorException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:IbanLib.Exceptions.ValidatorException" /> class with a
        ///     specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception, or a null reference if no inner exception is specified.
        /// </param>
        public ValidatorException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}