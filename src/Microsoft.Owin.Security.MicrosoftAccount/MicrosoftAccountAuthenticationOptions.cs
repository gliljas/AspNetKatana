﻿// <copyright file="MicrosoftAccountAuthenticationOptions.cs" company="Microsoft Open Technologies, Inc.">
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

using System.Collections.Generic;

namespace Microsoft.Owin.Security.MicrosoftAccount
{
    public class MicrosoftAccountAuthenticationOptions : AuthenticationOptions
    {
        public MicrosoftAccountAuthenticationOptions() : base("Microsoft")
        {
            Caption = "Microsoft";
            ReturnEndpointPath = "/signin-microsoft";
            AuthenticationMode = AuthenticationMode.Passive;
            Scope = new List<string> { "wl.basic" };
            BackChannelRequestTimeOut = 60 * 1000; // 60 seconds
        }

        public string Caption
        {
            get { return Description.Caption; }
            set { Description.Caption = value; }
        }

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public int BackChannelRequestTimeOut { get; set; }

        public IList<string> Scope { get; set; }

        public string ReturnEndpointPath { get; set; }
        public string SignInAsAuthenticationType { get; set; }

        public IMicrosoftAccountAuthenticationProvider Provider { get; set; }
        public ISecureDataHandler<AuthenticationExtra> StateDataHandler { get; set; }
    }
}