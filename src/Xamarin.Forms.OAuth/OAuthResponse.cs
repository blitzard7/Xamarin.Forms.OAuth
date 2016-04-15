﻿namespace Xamarin.Forms.OAuth
{
    public class OAuthResponse
    {
        private OAuthResponse(bool success)
        {
            Success = success;
        }

        internal OAuthResponse(OAuthAccessToken token)
            : this(true)
        {
            Token = token;
        }

        internal OAuthResponse(string error, string errorDescription)
            : this(false)
        {
            Error = error;
            ErrorDescription = errorDescription;
        }

        internal OAuthResponse(string code)
            : this(true)
        {
            Code = code;
            IsCode = true;
        }

        public bool Success { get; private set; }

        public bool IsCode { get; private set; }
        public string Code { get; private set; }
        public OAuthAccessToken Token { get; private set; }

        public string Error { get; private set; }
        public string ErrorDescription { get; private set; }

        public static implicit operator bool(OAuthResponse response)
        {
            return response.Success;
        }
    }
}