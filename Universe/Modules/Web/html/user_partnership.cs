﻿/*
 * Copyright (c) Contributors, http://virtual-planets.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 * For an explanation of the license of each contributor and the content it 
 * covers please see the Licenses directory.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the Virtual Universe Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections.Generic;
using Universe.Framework.Servers.HttpServer.Implementation;

namespace Universe.Modules.Web
{
	public class UserPartnershipPage : IWebInterfacePage
	{
		public string [] FilePath {
			get {
				return new [] {
					"html/user_partnership.html"
				};
			}
		}

		public bool RequiresAuthentication {
			get { return true; }
		}

		public bool RequiresAdminAuthentication {
			get { return false; }
		}
        
		public Dictionary<string, object> Fill(WebInterface webInterface, string filename, OSHttpRequest httpRequest,
			OSHttpResponse httpResponse, Dictionary<string, object> requestParameters, ITranslator translator, out string response)
		{
			response = null;
        	
			var vars = new Dictionary<string, object>();
        	
			// This page should show if a user already has a partner and show the ability to cancel the Partnership (with a payment defined in Economy.ini)
			// 
			// If the user doesn't have a partner, allow the user to send an Partnership invite to a person (internally send a message inworld to the person)
			//
			
			return vars;
		}
        
		public bool AttemptFindPage(string filename, ref OSHttpResponse httpResponse, out string text)
		{
			text = "";
			return false;
		}
	}
}