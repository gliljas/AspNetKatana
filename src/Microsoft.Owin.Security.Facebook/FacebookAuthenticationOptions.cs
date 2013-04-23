// <copyright file="FacebookAuthenticationOptions.cs" company="Microsoft Open Technologies, Inc.">
// Copyright 2011-2013 Microsoft Open Technologies, Inc. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using Microsoft.Owin.Security.DataProtection;

namespace Microsoft.Owin.Security.Facebook
{
    public class FacebookAuthenticationOptions : AuthenticationOptions
    {
        public FacebookAuthenticationOptions()
            : base("Facebook")
        {
            Caption = "Facebook";
            ReturnEndpointPath = "/signin-facebook";
            AuthenticationMode = AuthenticationMode.Passive;
        }

        public string AppId { get; set; }
        public string AppSecret { get; set; }

        public string Caption { get { return Description.Caption; } set { Description.Caption = value; } }
        public string ReturnEndpointPath { get; set; }
        public string SignInAsAuthenticationType { get; set; }

        public IDataProtection DataProtection { get; set; }
        public IFacebookAuthenticationProvider Provider { get; set; }
    }
}
