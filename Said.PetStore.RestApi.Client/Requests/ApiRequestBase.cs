using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Said.PetStore.RestApi.Client.Requests
{
    public abstract class ApiRequestBase
    {
        protected readonly RestClient? Client;
        protected readonly Dictionary<string, string> Headers = new()
        {
            {"accept", "application/json" },
            {"content-type", "application/json" }
        };

        protected ApiRequestBase(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }
    }
}