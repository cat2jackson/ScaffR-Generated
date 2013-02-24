/*
 * Copyright (c) Dominick Baier & Brock Allen.  All rights reserved.
 * see license.txt
 */

namespace DemoApplication.IdentityModel.Http.Cors.WebApi
{
    using System.Net.Http;

    class WebApiHttpResponse : IHttpResponseWrapper
    {
        HttpResponseMessage response;

        public WebApiHttpResponse(HttpResponseMessage response)
        {
            this.response = response;
        }

        public void AddHeader(string name, string value)
        {
            this.response.Headers.Add(name, value);
        }
    }
}
