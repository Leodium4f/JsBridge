namespace JSBridge.Hosting
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    ///     An exception returned from the Chakra engine.
    /// </summary>
    public class JavaScriptException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="JavaScriptException"/> class. 
        /// </summary>
        /// <param name="code">The error code returned.</param>
        public JavaScriptException(JavaScriptErrorCode code) :
            this(code, "A fatal exception has occurred in a JavaScript runtime")
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JavaScriptException"/> class. 
        /// </summary>
        /// <param name="code">The error code returned.</param>
        /// <param name="message">The error message.</param>
        public JavaScriptException(JavaScriptErrorCode code, string message) :
            base(message)
        {
            this.ErrorCode = code;
        }

        /// <summary>
        ///     Gets the error code.
        /// </summary>
        public JavaScriptErrorCode ErrorCode { get; }
    }
}