using System;

namespace DEMO_SDK
{
    class APIException : Exception
    {
        public int error { get; }
        public APIException (int code, String msg) : base(msg)
        {
            this.error = code;
        }

        public APIException( String msg) : base(msg)
        {
            this.error = -1;
        }
    }
}
