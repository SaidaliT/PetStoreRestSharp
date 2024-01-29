using Newtonsoft.Json;
using RestSharp;
using Said.PetStore.RestApi.Client.Models.PetModel;
using Said.PetStore.RestApi.Client.Utils;

namespace Said.PetStore.RestApi.Client.Requests.Pet
{
    public class PetApiRequests : ApiRequestBase
    {
        public PetApiRequests(string baseUrl) : base(baseUrl)
        {

        }

        /// <summary>
        /// Execute api post pet request
        /// </summary>
        /// <param name="_requestBody">Request body</param>
        /// <returns>Rest response instance</returns>
        public RestResponse ExecuteApiPostPetRequest(PetApiModelV2 _requestBody)
        {
            RestRequest request = new RestRequest(EndpointPaths.PetResourceUrl(), Method.Post);
            request.AddHeaders(Headers);
            string stringJson = JsonConvert.SerializeObject(_requestBody); //  Need to convert 'PetApiModelV2' data model into json format
            request.AddBody(stringJson);
            return Client!.Execute(request);
        }

        /// <summary>
        /// Execute api get pet by id request
        /// </summary>
        /// <param name="_requestBody">Request body</param>
        /// <returns>Rest response instance</returns>
        public RestResponse ExecuteApiGetPetByIdRequest(int petId)
        {
            RestRequest request = new RestRequest(EndpointPaths.PetByIdResourceUrl(petId), Method.Get);
            request.AddHeaders(Headers);
            return Client!.Execute(request);
        }

        /// <summary>
        /// Execute api put pet request
        /// </summary>
        /// <param name="_requestBody">Request body</param>
        /// <returns>Rest response instance</returns>
        public RestResponse ExecuteApiPutPetRequest(PetApiModelV2 _requestBody, int petId) // For put request it requires both request body and path parameter
        {
            RestRequest request = new RestRequest(EndpointPaths.PetByIdResourceUrl(petId), Method.Put);
            request.AddHeaders(Headers);
            string stringJson = JsonConvert.SerializeObject(_requestBody);
            request.AddBody(stringJson);
            return Client!.Execute(request);
        }
    }
}