﻿using System;

namespace LibUISharp
{
    /// <summary>
    /// The base exception for any Libui-related exceptions.
    /// </summary>
    [Serializable]
    public class LibuiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibuiException"/> class.
        /// </summary>
        public LibuiException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibuiException"/> class with the specified error message.
        /// </summary>
        /// <param name="message">The error message that specifies the reason for the exception.</param>
        public LibuiException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibuiException"/> class with the specified error message
        /// and <see langword="abstract"/>reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that specifies the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception.</param>
        public LibuiException(string message, Exception inner) : base(message, inner) { }        
    }
}