﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Microsoft.Owin.Security.OAuth;
using Thinktecture.IdentityServer.v3.AccessTokenValidation;

namespace Owin
{
    public static class ReferenceTokenValidationExtensions
    {
        public static IAppBuilder UseIdentitiyServerReferenceToken(this IAppBuilder app, ReferenceTokenValidationOptions options)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
                {
                    AccessTokenProvider = new ReferenceTokenProvider(options.Authority, options.AuthenticationType)
                });

            return app;
        }
    }
}