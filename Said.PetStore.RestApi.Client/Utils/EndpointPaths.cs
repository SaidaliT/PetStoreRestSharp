using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Said.PetStore.RestApi.Client.Utils
{
    public static class EndpointPaths
    {
        public static string PetResourceUrl() => "/pet";
        public static string PetByIdResourceUrl(long petId) => $"{PetResourceUrl()}/{petId}";
    }
}