﻿namespace Xamarin.Forms.OAuth.Providers
{
    public sealed class DropboxOAuthProvider : OAuthProvider
    {
        //does not refresh tokens
        internal DropboxOAuthProvider(string clientId, string clientSecret, string redirectUrl, params string[] scopes)
            : base(new OAuthProviderDefinition(
                "Dropbox",
                "https://www.dropbox.com/1/oauth2/authorize",
                "https://api.dropboxapi.com/1/oauth2/token",
                "https://api.dropbox.com/1/account/info",
                clientId,
                clientSecret,
                redirectUrl,
                scopes)
            {
                AuthorizationType = string.IsNullOrEmpty(clientSecret) ? AuthorizationType.Implicit : AuthorizationType.Explicit,
                TokenType = string.IsNullOrEmpty(clientSecret) ? TokenType.Url : TokenType.Bearer,
                IncludeRedirectUrlInTokenRequest = true,
                GraphIdProperty = "uid",
                GraphNameProperty = "display_name"
            })
        { }

        internal DropboxOAuthProvider(string clientId, string redirectUrl, params string[] scopes)
            : this(clientId, null, redirectUrl, scopes)
        { }
    }
}
